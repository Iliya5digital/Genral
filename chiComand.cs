case "chi":
                        {
                            foreach (var user in Database.Server.GamePoll.Values)
                            {
                                if (user.Player.Name.ToLower() == data[1].ToLower())
                                {
                                    if (user.Player.MyChi != null)
                                    {
                                        //!chi AmirKhaled[PM] 1 1 7 1
                                        byte Grade = byte.Parse(data[2]);
                                        int Gate = int.Parse(data[3]);
                                        byte Type = byte.Parse(data[4]);
                                        ushort Value = ushort.Parse(data[5]);
                                        switch (Grade)
                                        {
                                            case 1:
                                                {
                                                    user.Player.MyChi.Dragon.RerollGM(Gate, (Role.Instance.Chi.ChiAttributeType)Type, Value);
                                                    Program.ChiRanking.Upadte(Program.ChiRanking.Dragon, user.Player.MyChi.Dragon);
                                                    Role.Instance.Chi.ComputeStatus(user.Player.MyChi);
                                                    user.Equipment.QueryEquipment(user.Equipment.Alternante, false);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Send);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Upgrade);
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    user.Player.MyChi.Phoenix.RerollGM(Gate, (Role.Instance.Chi.ChiAttributeType)Type, Value);
                                                    Program.ChiRanking.Upadte(Program.ChiRanking.Dragon, user.Player.MyChi.Phoenix);
                                                    Role.Instance.Chi.ComputeStatus(user.Player.MyChi);
                                                    user.Equipment.QueryEquipment(user.Equipment.Alternante, false);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Send);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Upgrade);
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    user.Player.MyChi.Tiger.RerollGM(Gate, (Role.Instance.Chi.ChiAttributeType)Type, Value);
                                                    Program.ChiRanking.Upadte(Program.ChiRanking.Dragon, user.Player.MyChi.Tiger);
                                                    Role.Instance.Chi.ComputeStatus(user.Player.MyChi);
                                                    user.Equipment.QueryEquipment(user.Equipment.Alternante, false);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Send);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Upgrade);
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    user.Player.MyChi.Turtle.RerollGM(Gate, (Role.Instance.Chi.ChiAttributeType)Type, Value);
                                                    Program.ChiRanking.Upadte(Program.ChiRanking.Dragon, user.Player.MyChi.Turtle);
                                                    Role.Instance.Chi.ComputeStatus(user.Player.MyChi);
                                                    user.Equipment.QueryEquipment(user.Equipment.Alternante, false);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Send);
                                                    Project_ConquerX.Game.MsgServer.MsgChiInfo.MsgHandleChi.SendInfo(user, MsgChiInfo.Action.Upgrade);
                                                    break;
                                                }
                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                            break;
                        }