#region [SnowBanshee]
                    if (Boss > 0 && Family.ID == 20070)
                    {
                        const ushort GetStudyPoints = 1000;
                        if (killer.Player.DynamicID != killer.Player.UID)
                        {
                            #region [SoullDrop]
                            //Drop Random Soull------
                            uint SoullDrop = Family.ItemGenerator.GenerateSoullP3_P6(true);
                            for (int x = 0; x < 2; x++)
                            {
                                SoullDrop = Family.ItemGenerator.GenerateSoullP3_P6(true);
                                if (SoullDrop != 0)
                                {
                                    ushort xx = X;
                                    ushort yy = Y;
                                    if (killer.Map.AddGroundItem(ref xx, ref yy))
                                    {
                                        DropItem(stream, killer.Player.UID, killer.Map, SoullDrop, xx, yy, MsgFloorItem.MsgItem.ItemType.Item, 0, false, 0);
                                    }
                                }
                            }
                            #endregion
                            #region [ItemsDrop]
                            //Drop Random Items------
                            List<uint> RandDrob = new List<uint>() { 1088000, 720027, 730004, 755099, 754099 };
                            uint Ids = RandDrob[Program.GetRandom.Next(0, RandDrob.Count)];
                            for (int x = 0; x < 2; x++)
                            {
                                Ids = RandDrob[Program.GetRandom.Next(0, RandDrob.Count)];

                                MsgServer.MsgGameItem DataItem = new MsgServer.MsgGameItem();
                                DataItem.ITEM_ID = Ids;
                                Database.ItemType.DBItem DBItem;
                                if (Database.Server.ItemsBase.TryGetValue(Ids, out DBItem))
                                {
                                    DataItem.Durability = DataItem.MaximDurability = DBItem.Durability;
                                }
                                DataItem.Color = Role.Flags.Color.Red;
                                ushort xx = (ushort)Program.GetRandom.Next(X - 7, X + 7);
                                ushort yy = (ushort)Program.GetRandom.Next(Y - 7, Y + 7);
                                if (killer.Map.AddGroundItem(ref xx, ref yy, 3))
                                {
                                    MsgFloorItem.MsgItem DropItem = new MsgFloorItem.MsgItem(DataItem, xx, yy, MsgFloorItem.MsgItem.ItemType.Item, 0, DynamicID, Map, killer.Player.UID, true, GMap);

                                    if (killer.Map.EnqueueItem(DropItem))
                                    {

                                        DropItem.SendAll(stream, MsgFloorItem.MsgDropID.Visible);
                                    }
                                }
                            }
                            #endregion
                            #region [GermantDrop]
                            //Drop Random Garment------
                            Database.ItemType.DBItem aitem;
                            while (true)
                            {
                                var array = Database.ItemType.Garments.Values.ToArray();
                                aitem = array[Program.GetRandom.Next(0, array.Length)];
                                Database.CoatStorage.StorageItem DbGarment;
                                if (Database.CoatStorage.Garments.TryGetValue(aitem.ID, out DbGarment))
                                {
#if Encore
                                        if (DbGarment.Stars < 4)

#else
                                    if (DbGarment.Stars < 3)
#endif
                                    {
                                        MsgServer.MsgGameItem DataItem = new MsgServer.MsgGameItem();
                                        DataItem.ITEM_ID = aitem.ID;
                                        DataItem.EndDate = DateTime.Now.AddDays(7);
                                        DataItem.Activate = 1;
                                        Database.ItemType.DBItem DBItem;
                                        if (Database.Server.ItemsBase.TryGetValue(Database.ItemType.DragonBall, out DBItem))
                                        {
                                            DataItem.Durability = DataItem.MaximDurability = DBItem.Durability;
                                        }
                                        DataItem.Color = Role.Flags.Color.Red;
                                        ushort xx = (ushort)Program.GetRandom.Next(X - 7, X + 7);
                                        ushort yy = (ushort)Program.GetRandom.Next(Y - 7, Y + 7);
                                        if (killer.Map.AddGroundItem(ref xx, ref yy, 3))
                                        {
                                            MsgFloorItem.MsgItem DropItem = new MsgFloorItem.MsgItem(DataItem, xx, yy, MsgFloorItem.MsgItem.ItemType.Item, 0, DynamicID, Map, killer.Player.UID, true, GMap);

                                            if (killer.Map.EnqueueItem(DropItem))
                                            {
                                                DropItem.SendAll(stream, MsgFloorItem.MsgDropID.Visible);
                                            }
                                        }
                                        break;
                                    }
                                }
                            }
                            #endregion
                        }
                        if (killer.Team != null)
                        {
                            foreach (var member in killer.Team.Temates)
                            {
                                if (member != null && member.client != null && member.client.Player != null && member.client.Player.SubClass != null)
                                {
                                    if (member.client.Player.UID != killer.Player.UID)
                                    {
                                        member.client.Player.SubClass.AddStudyPoints(member.client, GetStudyPoints, stream);
                                    }
                                }
                            }
                        }
                        if (killer.Player.SubClass != null)
                            killer.Player.SubClass.AddStudyPoints(killer, GetStudyPoints, stream);
                        SendBossSysMesage(killer.Player.Name, GetStudyPoints, MsgServer.MsgMessage.ChatMode.System, MsgServer.MsgMessage.MsgColor.white);
                        Project_ConquerX_v2.Role.DragonIland.RunBanshee = false;
                        Project_ConquerX_v2.Role.DragonIland.BansheeAcpt = false;
                        return;
                    }
                    #endregion