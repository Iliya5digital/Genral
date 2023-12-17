public object scoreObj = new object();

public uint GetScorePosition(Client.GameClient killer)
        {
            lock (scoreObj)
            {
                if (this.Hunters == null) return 0;

                var a = Hunters.Values.OrderByDescending(p => p.HunterScore).ToArray();
                if (!Alive && !logged)
                {
                    string log = "[Bosses] Name: " + Name + " | Killer: " + killer.Player.Name + " | Hunters: ";
                    foreach (var hunter in a.Take(5))
                        log += hunter.HunterName + "     |      ";
                    Database.ServerDatabase.LoginQueue.Enqueue(log);
                    logged = true;
                }
                for (int x = 0; x < a.Length; x++)
                {
                    if (a[x].HunterUID == killer.Player.UID)
                        return (uint)(x + 1);
                }
                return 0;
            }
        }
        public void UpdateScore(ServerSockets.Packet stream, Client.GameClient killer, uint Damage)
        {
            try
            {
                lock (scoreObj)
                {
                    if (!Program.RankableFamilyIds.Contains(Family.ID))
                        return;
                    if (this.Hunters == null)
                        this.Hunters = new Dictionary<uint, MsgBossHarmRankingEntry>();
                    if (this.Hunters.ContainsKey(killer.Player.UID))
                    {
                        this.Hunters[killer.Player.UID].HunterScore += Damage;
                    }
                    else if (!this.Hunters.ContainsKey(killer.Player.UID))
                    {
                        this.Hunters.Add(killer.Player.UID, new MsgBossHarmRankingEntry() { HunterUID = killer.Player.UID, HunterScore = Damage, Rank = 0, HunterName = killer.Player.Name, ServerID = killer.Player.ServerID });
                    }
                    if (this.Hunters.Count == 0)
                        return;
                    var array = this.Hunters.Values.OrderByDescending(p => p.HunterScore).ToArray();
                    for (int x = 0; x < array.Length; x++)
                    {
                        array[x].Rank = (uint)(x + 1);
                    }
                    MsgServer.MsgBossHarmRanking Rank = new MsgServer.MsgBossHarmRanking();
                    Rank.MonsterID = this.Family.ID;
                    Rank.Type = (int)MsgBossHarmRanking.RankAction.ShowRespondForTheRest;
                    Rank.Hunters = array;
                    this.Send(stream.CreateBossHarmRankList(Rank));
                    array = null;
                }
            }
            catch (Exception ex)
            {
                MyConsole.WriteException(ex);
                MyConsole.SaveException(ex);
            }
        }

  #region [BossRankReward]
        public void GetBossReward(Client.GameClient killer, ServerSockets.Packet stream)
        {
            killer.Player.ConquerPoints += 50;
            killer.SendSysMesage("You have received 5,000 Conquer Points for being the last hitter of " + Name + "!", MsgMessage.ChatMode.TopLeft, MsgMessage.MsgColor.red);
            if (Map == 10250 || Map == 10137)//Deityland
            {
                foreach (var hunter in Hunters.Values)
                {
                    if (Database.Server.GamePoll.ContainsKey(hunter.HunterUID))
                    {
                        var client = Database.Server.GamePoll[hunter.HunterUID];
                        switch (this.GetScorePosition(client))
                        {
                            case 1:
                                client.Player.ConquerPoints += 1500;
                                //client.Inventory.AddItemWitchStack(4050001, 0, 400, stream);
                                //client.Inventory.AddItemWitchStack(4040001, 0, 700, stream);
                                client.Inventory.AddItemWitchStack(3321098, 0, 200, stream);
                                client.Inventory.AddItemWitchStack(3321107, 0, 100, stream);
                                client.Inventory.AddItemWitchStack(3321108, 0, 100, stream);
                                client.SendSysMesage("You have received 7.000,000 Conquer Points  And 200 LegendaryEssence And 100 SpiritStone + ChaosJade for being 1st hunter while defeating " + Name + "!", MsgMessage.ChatMode.TopLeft, MsgMessage.MsgColor.red);
                                break;
                            case 2:
                                client.Player.ConquerPoints += 1000;
                                //client.Inventory.AddItemWitchStack(4050001, 0, 200, stream);
                                //client.Inventory.AddItemWitchStack(4040001, 0, 550, stream);
                                client.Inventory.AddItemWitchStack(3321098, 0, 150, stream);
                                client.Inventory.AddItemWitchStack(3321107, 0, 100, stream);
                                client.Inventory.AddItemWitchStack(3321108, 0, 100, stream);
                                client.SendSysMesage("You have received 6.000,000 Conquer Points And 150 LegendaryEssence And 100 SpiritStone + ChaosJade for being 2nd hunter while defeating " + Name + "!", MsgMessage.ChatMode.TopLeft, MsgMessage.MsgColor.red);
                                break;
                            case 3:
                                client.Player.ConquerPoints += 500;
                                //client.Inventory.AddItemWitchStack(4050001, 0, 100, stream);
                                //client.Inventory.AddItemWitchStack(4040001, 0, 400, stream);
                                client.Inventory.AddItemWitchStack(3321098, 0, 100, stream);
                                client.Inventory.AddItemWitchStack(3321107, 0, 100, stream);
                                client.Inventory.AddItemWitchStack(3321108, 0, 100, stream);
                                client.SendSysMesage("You have received 5.000,000 Conquer Points  And 100 LegendaryEssence And 100 SpiritStone + ChaosJade for being 3rd hunter while defeating " + Name + "!", MsgMessage.ChatMode.TopLeft, MsgMessage.MsgColor.red);
                                break;
                        }
                    }
                }
            }
        }
        #endregion

//---------------------------------------------------------------------
public void Dead(ServerSockets.Packet stream, Client.GameClient killer, uint aUID, Role.GameMap GameMap)
//---------------------------------------------------------------------


 if (Map == 10137)
                    {
                        if (Family.ID == 20300)//nemesys
                            GetBossReward(killer, stream);
                        else if (Family.ID == 20070)//SnowBanshee
                            GetBossReward(killer, stream);
                        else if (Family.ID == 20160)//ThrillingSpook
                            GetBossReward(killer, stream);

                    }