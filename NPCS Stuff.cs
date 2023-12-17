#region [Stuff Sell]
                    case 508456:
                        {
                            dialog.Avatar(256);
                            switch(npcRequest.OptionID)
                            {
                                case 0:
                                    {
                                        dialog.Text("Select the item you want to buy \n");
                                        dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                        dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                        dialog.Option("Boots buy [ 145k ] Cps", 1);
                                        dialog.Option("Necklace buy [ 145k ] Cps", 2);
                                        dialog.Option("CrimsonRing buy [ 145k ] Cps", 3);
                                        dialog.Option("Volcano buy [ 145k ] Cps", 4);
                                        dialog.Option("DreamEarrings buy [ 145k ] Cps", 5);
                                        dialog.Option("HeavenFan buy [ 159k ] Cps", 6);
                                        dialog.Option("StarTower buy [ 159k ] Cps", 7);
                                        dialog.Option("tempestwing buy [ 159k ] Cps", 8);
                                        dialog.Option("Next..", 9);
                                        dialog.Option("Thanks!", 255);
                                        break;
                                    }
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                case 10:
                                case 11:
                                case 12:
                                case 13:
                                case 14:
                                case 15:
                                case 16:
                                case 17:
                                case 18:
                                case 19:
                                case 20:
                                case 21:
                                case 22:
                                case 23:
                                case 24:
                                case 25:
                                case 26:
                                case 27:
                                case 28:
                                case 29:
                                case 30:
                                case 31:
                                case 32:
                                case 33:
                                case 34:
                                case 35:
                                case 36:
                                case 37:
                                case 38:
                                case 39:
                                case 40:
                                case 41:
                                case 42:
                                case 43:
                                case 44:
                                case 45:
                                case 46:
                                case 47:
                                case 48:
                                case 49:
                                case 50:
                                case 51:
                                case 52:
                                case 53:
                                case 54:
                                case 55:
                                case 56:
                                case 57:
                                case 58:
                                case 59:
                                case 60:
                                case 61:
                                case 62:
                                case 100:
                                    {
                                        uint boots = 250000;
                                        uint Tower = 300000;
                                        uint Wpans = 200000;
                                        uint EpicWpans = 2000000;
                                        uint epictoist = 1000000;
                                        if(npcRequest.OptionID == 100)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("Boots buy [ 145k ] Cps", 1);
                                            dialog.Option("Necklace buy [ 145k ] Cps", 2);
                                            dialog.Option("CrimsonRing buy [ 145k ] Cps", 3);
                                            dialog.Option("Volcano buy [ 145k ] Cps", 4);
                                            dialog.Option("DreamEarrings buy [ 145k ] Cps", 5);
                                            dialog.Option("HeavenFan buy [ 159k ] Cps", 6);
                                            dialog.Option("StarTower buy [ 159k ] Cps", 7);
                                            dialog.Option("tempestwing buy [ 159k ] Cps", 8);
                                            dialog.Option("Next..", 9);
                                            dialog.Option("Thanks!", 255);
                                        }
                                        #region Stuff Basic
                                        #region [Boots]
                                        if (npcRequest.OptionID == 1)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(160249, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [Necklace]
                                        if (npcRequest.OptionID == 2)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(120269, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [CrimsonRing]
                                        if (npcRequest.OptionID == 3)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(150269, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [Volcano]
                                        if (npcRequest.OptionID == 4)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(151249, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DreamEarrings]
                                        if (npcRequest.OptionID == 5)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(117309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [HeavenFan]
                                        if (npcRequest.OptionID == 6)
                                        {
                                            if (client.Entity.ConquerPoints >= Tower)
                                            {
                                                client.Inventory.AddStuff(201009, 12, 1, 1, 0, 103, 103, false);
                                                client.Entity.ConquerPoints -= Tower;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Tower + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [StarTower]
                                        if (npcRequest.OptionID == 7)
                                        {
                                            if (client.Entity.ConquerPoints >= Tower)
                                            {
                                                client.Inventory.AddStuff(202009, 12, 1, 1, 0, 123, 123, false);
                                                client.Entity.ConquerPoints -= Tower;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Tower + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [tempestwing]
                                        if (npcRequest.OptionID == 8)
                                        {
                                            if (client.Entity.ConquerPoints >= Tower)
                                            {
                                                client.Inventory.AddStuff(204009, 12, 1, 1, 0, 103, 123, false);
                                                client.Entity.ConquerPoints -= Tower;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Tower + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        if(npcRequest.OptionID == 9)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("Stuff Pirate", 10);
                                            dialog.Option("Stuff Trojan", 11);
                                            dialog.Option("Stuff Archer & Assassin", 12);
                                            dialog.Option("Stuff Ninja", 13);
                                            dialog.Option("Stuff Monk", 14);
                                            dialog.Option("Stuff Warrior", 15);
                                            dialog.Option("Stuff Taoist", 16);
                                            dialog.Option("Stuff LE-Long", 17);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [Stuff Pirate]
                                        if(npcRequest.OptionID == 10)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("CaptainRapier buy [ " + Wpans + " ] Cps", 18);
                                            dialog.Option("LordPistol buy [ " + Wpans + " ]", 19);
                                            dialog.Option("DarkDragonCoat buy [ " + boots + " ] Cps", 20);
                                            dialog.Option("DominatorHat buy [ " + boots + " ] Cps", 21);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [CaptainRapier]
                                        if (npcRequest.OptionID == 18)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(611439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [LordPistol]
                                        if (npcRequest.OptionID == 19)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(612439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DarkDragonCoat]
                                        if (npcRequest.OptionID == 20)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(139309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DominatorHat]
                                        if (npcRequest.OptionID == 21)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(144309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Trojan]
                                        if (npcRequest.OptionID == 11)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("SkyBlade buy [ " + Wpans + " ] Cps", 22);
                                            dialog.Option("SquallSword buy [ " + Wpans + " ] Cps", 23);
                                            dialog.Option("NirvanaClub buy [ " + Wpans + " ] Cps", 24);
                                            dialog.Option("ObsidianArmor buy [ " + boots + " ] Cps", 25);
                                            dialog.Option("PeerlessCoronet buy [ " + boots + " ] Cps", 26);
                                            dialog.Option("TrojanEpc buy [ " + EpicWpans + " ] Cps", 27);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [SkyBlade]
                                        if (npcRequest.OptionID == 22)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(410439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [SquallSword]
                                        if (npcRequest.OptionID == 23)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(420439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [NirvanaClub]
                                        if (npcRequest.OptionID == 24)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(480439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [ObsidianArmor]
                                        if (npcRequest.OptionID == 25)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(130309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [PeerlessCoronet]
                                        if (npcRequest.OptionID == 26)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(118309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [FangCrossSaber]
                                        if (npcRequest.OptionID == 27)
                                        {
                                            if (client.Entity.ConquerPoints >= EpicWpans)
                                            {
                                                client.Inventory.AddStuff(614439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= EpicWpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + EpicWpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Archer]
                                        if (npcRequest.OptionID == 12)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("FantasyKnife buy [ " + Wpans + " ] Cps", 28);
                                            dialog.Option("HeavenlyBow buy [ " + Wpans + " ] Cps", 29);
                                            dialog.Option("WelkinCoat buy [ " + boots + " ] Cps", 30);
                                            dialog.Option("WhiteTigerHat buy [ " + boots + " ] Cps", 31);
                                            dialog.Option("HeavenPlume buy [ " + boots + " ] Cps", 32);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [FantasyKnife]
                                        if (npcRequest.OptionID == 28)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(613429, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [HeavenlyBow]
                                        if (npcRequest.OptionID == 29)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(500429, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [WelkinCoat]
                                        if (npcRequest.OptionID == 30)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(133309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [WhiteTigerHat]
                                        if (npcRequest.OptionID == 31)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(113309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [HeavenPlume]
                                        if (npcRequest.OptionID == 32)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(142309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Ninja]
                                        if (npcRequest.OptionID == 13)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("HanzoKatana buy [ " + Wpans + " ] Cps", 33);
                                            dialog.Option("SilenceScythe buy [ " + Wpans + " ] Cps", 34);
                                            dialog.Option("Epc Ninja buy [ " + EpicWpans + " ] Cps", 35);
                                            dialog.Option("NightmareVest buy [ " + boots + " ] Cps", 36);
                                            dialog.Option("RambleVeil buy [ " + boots + " ] Cps", 37);
                                            dialog.Option("NightmareHood buy [ " + boots + " ] Cps", 38);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [HanzoKatana]
                                        if (npcRequest.OptionID == 33)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(601439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [SilenceScythe]
                                        if (npcRequest.OptionID == 34)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(511439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [Nobunaga`sSwiftClaw]
                                        if (npcRequest.OptionID == 35)
                                        {
                                            if (client.Entity.ConquerPoints >= EpicWpans)
                                            {
                                                client.Inventory.AddStuff(616439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= EpicWpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + EpicWpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [NightmareVest]
                                        if (npcRequest.OptionID == 36)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(135309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [RambleVeil]
                                        if (npcRequest.OptionID == 37)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(112309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [NightmareHood]
                                        if (npcRequest.OptionID == 38)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(123309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Monk]
                                        if (npcRequest.OptionID == 14)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("LazuritePrayerBeads buy [ " + Wpans + " ] Cps", 39);
                                            dialog.Option("Epc Monk buy [ " + EpicWpans + " ] Cps", 40);
                                            dialog.Option("WhiteLotusFrock buy [ " + boots + " ] Cps", 41);
                                            dialog.Option("XumiCap buy [ " + boots + " ] Cps", 42);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [LazuritePrayerBeads]
                                        if (npcRequest.OptionID == 39)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(610439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [Kingcolumn]
                                        if (npcRequest.OptionID == 40)
                                        {
                                            if (client.Entity.ConquerPoints >= EpicWpans)
                                            {
                                                client.Inventory.AddStuff(622439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= EpicWpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + EpicWpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [WhiteLotusFrock]
                                        if (npcRequest.OptionID == 41)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(136309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [XumiCap]
                                        if (npcRequest.OptionID == 42)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(143309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Warrior]
                                        if (npcRequest.OptionID == 15)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("SpearOfWrath buy [ " + Wpans + " ] Cps", 43);
                                            dialog.Option("OccultWand buy [ " + Wpans + " ] Cps", 44);
                                            dialog.Option("VigorGlaive buy [ " + Wpans + " ] Cps", 45);
                                            dialog.Option("HawkPoleaxe buy [ " + Wpans + " ] Cps", 46);
                                            dialog.Option("FlameHalbert buy [ " + Wpans + " ] Cps", 47);
                                            dialog.Option("ImperiousArmor buy [ " + boots + " ] Cps", 48);
                                            dialog.Option("CelestialShield  buy [ " + boots + " ] Cps", 49);
                                            dialog.Option("SteelHelmet buy [ " + boots + " ] Cps", 50);
                                            dialog.Option("DragonHeadband buy [ " + boots + " ] Cps", 51);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [SpearOfWrath]
                                        if (npcRequest.OptionID == 43)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(560439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [OccultWand]
                                        if (npcRequest.OptionID == 44)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(561439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [VigorGlaive]
                                        if (npcRequest.OptionID == 45)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(510439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [HawkPoleaxe]
                                        if (npcRequest.OptionID == 46)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(530439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [FlameHalbert]
                                        if (npcRequest.OptionID == 47)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(580439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [ImperiousArmor]
                                        if (npcRequest.OptionID == 48)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(131309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [CelestialShield]
                                        if (npcRequest.OptionID == 49)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(900309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [SteelHelmet]
                                        if (npcRequest.OptionID == 50)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(111309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DragonHeadband]
                                        if (npcRequest.OptionID == 51)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(141309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff Taoist]
                                        if (npcRequest.OptionID == 16)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("SupremeSword buy [ " + Wpans + " ] Cps", 52);
                                            dialog.Option("Epic ImperialBacksword buy [ " + EpicWpans + " ] Cps", 53);
                                            dialog.Option("Epic UniverseHossu buy [ " + epictoist + " ] Cps", 54);
                                            dialog.Option("EternalRobe buy [ " + boots + " ] Cps", 55);
                                            dialog.Option("DistinctCap buy [ " + boots + " ] Cps", 56);
                                            dialog.Option("DreamEarrings buy [ " + boots + " ] Cps", 57);
                                            dialog.Option("WyvernBracelet buy [ " + boots + " ] Cps", 58);
                                            dialog.Option("NiftyBag buy [ " + boots + " ] Cps", 59);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [SupremeSword]
                                        if (npcRequest.OptionID == 52)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(421439, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [ImperialBacksword]
                                        if (npcRequest.OptionID == 53)
                                        {
                                            if (client.Entity.ConquerPoints >= EpicWpans)
                                            {
                                                client.Inventory.AddStuff(620439, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= EpicWpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + EpicWpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [UniverseHossu]
                                        if (npcRequest.OptionID == 54)
                                        {
                                            if (client.Entity.ConquerPoints >= epictoist)
                                            {
                                                client.Inventory.AddStuff(619439, 12, 1, 1, 0, 0, 0, false);
                                                client.Entity.ConquerPoints -= epictoist;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + epictoist + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [EternalRobe]
                                        if (npcRequest.OptionID == 55)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(134309, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DistinctCap]
                                        if (npcRequest.OptionID == 56)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(114309, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [DreamEarrings]
                                        if (npcRequest.OptionID == 57)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(117309, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [WyvernBracelet]
                                        if (npcRequest.OptionID == 58)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(152279, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [NiftyBag]
                                        if (npcRequest.OptionID == 59)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(121269, 12, 1, 7, 250, 3, 3, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        #region [Stuff LE-Long]
                                        if(npcRequest.OptionID == 17)
                                        {
                                            dialog.Text("Select the item you want to buy \n");
                                            dialog.Text("you own [ " + client.Entity.ConquerPoints + " ] Cps \n");
                                            dialog.Text("All item +12 2 Socket damig -7 hp 250");
                                            dialog.Option("CombatSuit buy [ " + boots + " ] Cps", 60);
                                            dialog.Option("LegendHood buy [ " + boots + " ] Cps", 61);
                                            dialog.Option("SkyNunchaku buy [ " + Wpans + " ] Cps", 62);
                                            dialog.Option("Back..", 100);
                                            dialog.Option("thank you", 255);
                                        }
                                        #region [CombatSuit]
                                        if (npcRequest.OptionID == 60)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(138309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [LegendHood]
                                        if (npcRequest.OptionID == 61)
                                        {
                                            if (client.Entity.ConquerPoints >= boots)
                                            {
                                                client.Inventory.AddStuff(148309, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= boots;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + boots + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #region [SkyNunchaku]
                                        if (npcRequest.OptionID == 63)
                                        {
                                            if (client.Entity.ConquerPoints >= Wpans)
                                            {
                                                client.Inventory.AddStuff(617439, 12, 1, 7, 250, 13, 13, false);
                                                client.Entity.ConquerPoints -= Wpans;
                                            }
                                            else
                                            {
                                                dialog.Text("Sorry you do not have " + Wpans + " cps");
                                                dialog.Option("Sorry", 255);
                                            }
                                        }
                                        #endregion
                                        #endregion
                                        break;
                                    }
                            }
                            break;
                        }
                    #endregion
//---------------------------------------------Inventory-------------------------------------------
public bool AddStuff(uint id, byte plus, byte times, byte blees, byte hp, byte soc1, byte soc2, bool bound = false)
        {
            try
            {
                Database.ConquerItemInformation infos = new Database.ConquerItemInformation(id, plus);
                while (times > 0)
                {

                    ConquerItem _ExistingItem;
                    Database.ConquerItemInformation iteminfo = new Database.ConquerItemInformation(id, 0);
                    if (Owner.Inventory.Contains(iteminfo.BaseInformation.ID, bound, iteminfo.BaseInformation.StackSize, out _ExistingItem))
                    {
                        if (_ExistingItem.StackSize == 0)
                            _ExistingItem.StackSize = 1;
                        ushort _StackCount = iteminfo.BaseInformation.StackSize;
                        _StackCount -= (ushort)_ExistingItem.StackSize;
                        if (_StackCount >= 1)
                            _StackCount += 1;
                        _ExistingItem.StackSize += 1;
                        Database.ConquerItemTable.UpdateStack(_ExistingItem);
                        _ExistingItem.Mode = Game.Enums.ItemMode.Update;
                        _ExistingItem.Send(Owner);
                        _ExistingItem.Mode = Game.Enums.ItemMode.Default;
                    }
                    else
                    {
                        if (Count <= 39)
                        {
                            //<<<<<<<<<<--- By AmirAl3shre --->>>>>>>>>>
                            ConquerItem item = new Network.GamePackets.ConquerItem(true);
                            item.ID = id;
                            item.Color = Game.Enums.Color.White;
                            item.Plus = plus;
                            item.Bound = bound;
                            item.Bless = blees;
                            item.Enchant = hp;
                            item.SocketOne = (Game.Enums.Gem)soc1;
                            item.SocketTwo = (Game.Enums.Gem)soc2;
                            item.Durability = item.MaximDurability = infos.BaseInformation.Durability;
                            item.StackSize = 1;
                            item.MaxStackSize = infos.BaseInformation.StackSize;
                            Add(item, Game.Enums.ItemUse.CreateAndAdd);
                            Database.ConquerItemTable.UpdateStack(item);
                        }
                    }
                    times--;
                }
            }
            catch (Exception e)
            {
                Program.SaveException(e);
            }
            return true;
        }