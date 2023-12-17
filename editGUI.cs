case "opengui":
                        {
                            using (var rec = new ServerSockets.RecycledPacket())
                            {
                                var stream = rec.GetStream();
//opengui 3250@
                                ActionQuery action = new ActionQuery()
                                {
                                    ObjId = client.Player.UID,
                                    Type = ActionType.OpenCustom,
                                    Timestamp = (int)Extensions.Time32.Now.Value,
                                    dwParam = uint.Parse(data[1]),
                                    wParam1 = client.Player.X,
                                    wParam2 = client.Player.Y,

                                };
                                client.Send(stream.ActionCreate(&action));


                            }
                            break;
                        }