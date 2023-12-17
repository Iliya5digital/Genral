 [NpcAttribute(NpcID.GlowTownPortal1)]
        public static void GlowTownPortal1(Client.GameClient client, ServerSockets.Packet stream, byte Option, string Input, uint id)
        {
            Dialog data = new Dialog(client, stream);
            switch (Option)
            {

                case 0:
                    {
                        data.AddText("Are you sure you want to return to Glowtown?")
                            .AddOption("Yes.", 1)
                           .AddOption("No.", 255).AddAvatar(156).FinalizeDialog();
                        break;
                    }
                case 1:
                    {
                        client.Teleport((ushort)(95 - Program.GetRandom.Next(0, 5)), (ushort)(412 - Program.GetRandom.Next(0, 5)), 10137);
                        break;
                    }
                default:
                    break;
            }
        }
        [NpcAttribute(NpcID.GlowTownPortal2)]
        public static void GlowTownPortal2(Client.GameClient client, ServerSockets.Packet stream, byte Option, string Input, uint id)
        {
            Dialog data = new Dialog(client, stream);
            switch (Option)
            {

                case 0:
                    {
                        data.AddText("Are you sure you want to return to Glowtown?")
                            .AddOption("Yes.", 1)
                           .AddOption("No.", 255).AddAvatar(156).FinalizeDialog();
                        break;
                    }
                case 1:
                    {
                        client.Teleport((ushort)(95 - Program.GetRandom.Next(0, 5)), (ushort)(412 - Program.GetRandom.Next(0, 5)), 10137);
                        break;
                    }
                default:
                    break;
            }
        }
        [NpcAttribute(NpcID.GlowTownPortal3)]
        public static void GlowTownPortal3(Client.GameClient client, ServerSockets.Packet stream, byte Option, string Input, uint id)
        {
            Dialog data = new Dialog(client, stream);
            switch (Option)
            {

                case 0:
                    {
                        data.AddText("Are you sure you want to return to Glowtown?")
                            .AddOption("Yes.", 1)
                           .AddOption("No.", 255).AddAvatar(156).FinalizeDialog();
                        break;
                    }
                case 1:
                    {
                        client.Teleport((ushort)(95 - Program.GetRandom.Next(0, 5)), (ushort)(412 - Program.GetRandom.Next(0, 5)), 10137);
                        break;
                    }
                default:
                    break;
            }
        }

GlowTownPortal1 = 20571,
        GlowTownPortal2 = 20572,
        GlowTownPortal3 = 20573,