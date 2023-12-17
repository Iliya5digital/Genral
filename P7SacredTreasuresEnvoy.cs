[NpcAttribute(NpcID.P7SacredTreasuresEnvoy)]
        public static void P7SacredTreasuresEnvoy(Client.GameClient client, ServerSockets.Packet stream, byte Option, string Input, uint id)
        {
            Dialog data = new Dialog(client, stream);
            switch (Option)
            {
                case 0:
                    {
                        data.AddText("There`s a mysterious treasure sealed since the ancient times. With a Savage Bone, you can explore and have a chance to get Sacred refinery materials, rare")
                            .AddText("~weapon accessories, and even the legendary P7 Dragon Soul.")
                            .AddOption("I~wanna~explore.", 1)
                            .AddOption("Special~exploration.", 2)
                            .AddOption("I~see.", 255)
                            .AddAvatar(200)
                            .FinalizeDialog();
                        break;
                    }
                case 1:
                    {
                        data.AddText("The Nemesis Tyrant in the DragonIland Sea has the Savage Bones. You can use one to explore each time.")
                            .AddOption("Use~a~Savage~Bone.", 3)
                            .AddOption("Send~me~there.", 4)
                            .AddOption("I~see.", 255)
                            .AddAvatar(200)
                            .FinalizeDialog();
                        break;
                    }
                case 2:
                    {
                        data.AddText("If you don`t have a Savage Bone, you can also pay 3700 or 17.000 CPs to explore. Of course, the more you pay, the better you get.")
                           .AddText("~How much would you like to pay?")
                           .AddOption("3700~CPs.", 5)
                           .AddOption("17.000~CPs.", 6)
                           .AddOption("I~see.", 255)
                           .AddAvatar(200)
                           .FinalizeDialog();
                        break;
                    }
                #region [SavageBone]
                case 3:
                    {
                        if (client.Inventory.Contain(3004181, 1))
                        {
                            data.AddText("The Nemesis Tyrant in the DragonIland Sea has the Savage Bones. You can use one to explore each time.")
                                .AddOption("Use~a~Savage~Bone.", 3)
                                .AddOption("I~see.", 255)
                                .AddAvatar(200)
                                .FinalizeDialog();
                            uint[] ItemID = new uint[] 
                            { 
                                3004251, 3004252, 3004253, 3004254, 3004255, 3004256,
                                3004249, 3004245, 3004248, 3004244, 3004247, 3004243
                            };
                            uint Itemz = ItemID[Program.GetRandom.Next(ItemID.Length)];
                            #region MessageSend
                            if (Itemz == 3004251)
                                client.CreateBoxDialog("You received a CarpFishPoleScrap.");
                            else if (Itemz == 3004252)
                                client.CreateBoxDialog("You received a SpecialOarScrap.");
                            else if (Itemz == 3004253)
                                client.CreateBoxDialog("You received a CucumberHammerScrap.");
                            else if (Itemz == 3004254)
                                client.CreateBoxDialog("You received a CatHammerScrap.");
                            else if (Itemz == 3004255)
                                client.CreateBoxDialog("You received a RacoonRacketScrap.");
                            else if (Itemz == 3004256)
                                client.CreateBoxDialog("You received a UltraRacketScrap.");
                            else if (Itemz == 3004249)
                                client.CreateBoxDialog("You received a SacredRefineryPack.");
                            else if (Itemz == 3004245)
                                client.CreateBoxDialog("You received a SacredRefineryScrap.");
                            else if (Itemz == 3004248)
                                client.CreateBoxDialog("You received a P7EquipmentSoulPack.");
                            else if (Itemz == 3004244)
                                client.CreateBoxDialog("You received a P7EquipmentSoulScrap.");
                            else if (Itemz == 3004247)
                                client.CreateBoxDialog("You received a P7WeaponSoulPack.");
                            else if (Itemz == 3004243)
                                client.CreateBoxDialog("You received a P7WeaponSoulScrap.");
                            #endregion
                            if (Itemz == 3004249 || Itemz == 3004248 || Itemz == 3004247)
                                client.Inventory.Add(stream, Itemz);
                            else
                                client.Inventory.AddItemWitchStack(Itemz, 0, 1, stream);
                            client.Inventory.Remove(3004181, 1, stream);
                        }
                        break;
                    }
                #endregion
                case 4:
                    {
                        if (client.Player.Level >= 120)
                            client.Teleport(95, 409, 10137, 0);
                        else
                            client.CreateBoxDialog("Sorry only level 120 is allowed to enter");
                        break;
                    }
                #region [SpecialExploration]
                #region Buy-3k>cps
                case 5:
                    {
                        data.AddText("If you don`t have a Savage Bone, you can also pay 3700 CPs to explore. Of course, the more you pay, the better you get.")
                           .AddText("~How much would you like to pay?")
                           .AddOption("3700~CPs.", 5)
                           //.AddOption("17.000~CPs.", 6)
                           .AddOption("I~see.", 255)
                           .AddAvatar(200)
                           .FinalizeDialog();
                        uint[] ItemID = new uint[] 
                            { 
                                3004251, 3004252, 3004253, 3004254, 3004255, 3004256,
                                3004249, 3004245, 3004248, 3004244, 3004247, 3004243
                            };
                  back: uint Itemz = ItemID[Program.GetRandom.Next(ItemID.Length)];
                        if (Role.Core.Rate(80))
                        {
                            if (Itemz == 3004249 || Itemz == 3004248 || Itemz == 3004247)
                                goto back;
                        }
                        #region MessageSend
                        if (Itemz == 3004251)
                            client.CreateBoxDialog("You received a CarpFishPoleScrap.");
                        else if (Itemz == 3004252)
                            client.CreateBoxDialog("You received a SpecialOarScrap.");
                        else if (Itemz == 3004253)
                            client.CreateBoxDialog("You received a CucumberHammerScrap.");
                        else if (Itemz == 3004254)
                            client.CreateBoxDialog("You received a CatHammerScrap.");
                        else if (Itemz == 3004255)
                            client.CreateBoxDialog("You received a RacoonRacketScrap.");
                        else if (Itemz == 3004256)
                            client.CreateBoxDialog("You received a UltraRacketScrap.");
                        else if (Itemz == 3004249)
                            client.CreateBoxDialog("You received a SacredRefineryPack.");
                        else if (Itemz == 3004245)
                            client.CreateBoxDialog("You received a SacredRefineryScrap.");
                        else if (Itemz == 3004248)
                            client.CreateBoxDialog("You received a P7EquipmentSoulPack.");
                        else if (Itemz == 3004244)
                            client.CreateBoxDialog("You received a P7EquipmentSoulScrap.");
                        else if (Itemz == 3004247)
                            client.CreateBoxDialog("You received a P7WeaponSoulPack.");
                        else if (Itemz == 3004243)
                            client.CreateBoxDialog("You received a P7WeaponSoulScrap.");
                        #endregion
                        if (Itemz == 3004249 || Itemz == 3004248 || Itemz == 3004247)
                            client.Inventory.Add(stream, Itemz);
                        else
                            client.Inventory.AddItemWitchStack(Itemz, 0, 1, stream);
                        client.Inventory.Remove(3004181, 1, stream);
                        break;
                    }
                #endregion
                #region Buy-17k>cps
                case 6:
                    {
                        data.AddText("If you don`t have a Savage Bone, you can also pay 17.000~CPs to explore. Of course, the more you pay, the better you get.")
                           .AddText("~How much would you like to pay?")
                           //.AddOption("3700~CPs.", 5)
                           .AddOption("17.000~CPs.", 6)
                           .AddOption("I~see.", 255)
                           .AddAvatar(200)
                           .FinalizeDialog();
                        uint[] ItemID = new uint[] 
                            { 
                                3004249, 3004245, 3004248, 3004244, 3004247, 3004243
                            };
                    back: uint Itemz = ItemID[Program.GetRandom.Next(ItemID.Length)];
                        if (Role.Core.Rate(50))
                        {
                            if (Itemz == 3004249 || Itemz == 3004248 || Itemz == 3004247)
                                goto back;
                        }
                        #region MessageSend
                        if (Itemz == 3004251)
                            client.CreateBoxDialog("You received a CarpFishPoleScrap.");
                        else if (Itemz == 3004252)
                            client.CreateBoxDialog("You received a SpecialOarScrap.");
                        else if (Itemz == 3004253)
                            client.CreateBoxDialog("You received a CucumberHammerScrap.");
                        else if (Itemz == 3004254)
                            client.CreateBoxDialog("You received a CatHammerScrap.");
                        else if (Itemz == 3004255)
                            client.CreateBoxDialog("You received a RacoonRacketScrap.");
                        else if (Itemz == 3004256)
                            client.CreateBoxDialog("You received a UltraRacketScrap.");
                        else if (Itemz == 3004249)
                            client.CreateBoxDialog("You received a SacredRefineryPack.");
                        else if (Itemz == 3004245)
                            client.CreateBoxDialog("You received a SacredRefineryScrap.");
                        else if (Itemz == 3004248)
                            client.CreateBoxDialog("You received a P7EquipmentSoulPack.");
                        else if (Itemz == 3004244)
                            client.CreateBoxDialog("You received a P7EquipmentSoulScrap.");
                        else if (Itemz == 3004247)
                            client.CreateBoxDialog("You received a P7WeaponSoulPack.");
                        else if (Itemz == 3004243)
                            client.CreateBoxDialog("You received a P7WeaponSoulScrap.");
                        #endregion
                        if (Itemz == 3004249 || Itemz == 3004248 || Itemz == 3004247)
                            client.Inventory.Add(stream, Itemz);
                        else
                            client.Inventory.AddItemWitchStack(Itemz, 0, 1, stream);
                        client.Inventory.Remove(3004181, 1, stream);
                        break;
                    }
                #endregion
                #endregion
            }
        }