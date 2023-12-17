public unsafe ServerSockets.Packet GetArray(ServerSockets.Packet stream, bool WindowsView)
        {
            //Stream Edit by X-Team
            stream.InitWriter();
            stream.Write(Extensions.Time32.Now.Value);//TimeStamp = 4
            stream.Write(Mesh);//Mesh = 8
            stream.Write(UID);//UID = 12
            stream.Write(GuildID);//GuildID = 16
            if (Program.ServerConfig.IsInterServer == false && Owner.OnInterServer == false)
                stream.Write((ushort)GuildRank);//GuildRank = 20
            else
                stream.ZeroFill(2);
            stream.Write((uint)0);//unknow = 22
            for (int x = 0; x < BitVector.bits.Length; x++)
                stream.Write(BitVector.bits[x]);
            if (Game.MsgTournaments.MsgSchedules.CurrentTournament.Type == Game.MsgTournaments.TournamentType.FreezeWar
               || Game.MsgTournaments.MsgSchedules.CurrentTournament.Type == Game.MsgTournaments.TournamentType.FootBall
               || Game.MsgTournaments.MsgSchedules.CurrentTournament.Type == Game.MsgTournaments.TournamentType.TeamDeathMatch)
            {
                if (Game.MsgTournaments.MsgSchedules.CurrentTournament.InTournament(Owner))
                    stream.Write((ushort)0);
                else
                    stream.Write((ushort)AparenceType);
            }
            else
                stream.Write((ushort)AparenceType);//AparenceType = 54
            stream.Write(HeadId);//HeadId = 56
            stream.Write(GarmentId);//GarmentId = 60
            stream.Write(ArmorId);//ArmorId = 64
            stream.Write(LeftWeaponId);//LeftWeaponId = 68
            stream.Write(RightWeaponId);//RightWeaponId = 72
            stream.Write(LeftWeaponAccessoryId);//LeftWeaponAccessoryId = 76
            stream.Write(RightWeaponAccessoryId);//RightWeaponAccessoryId = 80
            stream.Write(SteedId);//SteedId = 84
            stream.Write(MountArmorId);//MountArmorId = 88
            stream.Write(WingId);//WingId = 92
            stream.Write((byte)WingPlus);//WingPlus = 96
            stream.Write(WingProgress);//WingProgress = 97
            stream.ZeroFill(10);
            stream.Write(HitPoints);//HitPoints = 111
            stream.Write((uint)0);//?? unknow 115
            stream.Write(X);//X = 119
            stream.Write(Y);//Y = 121
            stream.Write(Hair);//Hair = 123
            stream.Write((byte)Angle);//Angle = 125
            stream.Write((uint)Action);//Action = 126
            stream.ZeroFill(3);
            stream.Write(Reborn);//Reborn = 133
            stream.Write(Level);//Level = 134
            stream.Write((byte)(WindowsView ? 1 : 0));//WindowsView = 136
            stream.Write((byte)Away);//Away = 137
            stream.Write(ExtraBattlePower);//ExtraBattlePower = 138
            stream.ZeroFill(12);
            stream.Write((uint)(FlowerRank + 10000));//FlowerRank = 154
            stream.Write((uint)NobilityRank);//NobilityRank = 158
            stream.Write(ColorArmor);//ColorArmor = 162
            stream.Write(ColorShield);//ColorShield = 164
            stream.Write(ColorHelment);//ColorHelment = 166
            stream.Write((uint)0);//QuizPoints = 168
            stream.Write(SteedPlus);//SteedPlus = 172
            stream.Write((ushort)0);//unknow = 174
            stream.Write(SteedColor);//SteedColor = 178
            stream.Write((ushort)Enilghten);//Enilghten = 182
            stream.Write((ushort)0);//MeritPoints = 184
            stream.ZeroFill(8);
            stream.Write(ClanUID);//ClanUID = 194
            stream.Write((uint)ClanRank);//ClanRank = 198
            stream.Write((uint)0);//unknow = 202
            stream.Write((ushort)MyTitle);//MyTitle = 206
            stream.ZeroFill(9);
            stream.Write((byte)(Owner.IsWatching() ? 1 : 0));//ArenaWatching = 217
            stream.ZeroFill(3);
            stream.Write(HeadSoul);//HeadSoul = 221
            stream.Write(ArmorSoul);//ArmorSoul = 225
            stream.Write(LeftWeapsonSoul);//LeftWeapsonSoul = 229
            stream.Write(RightWeapsonSoul);//RightWeapsonSoul = 233
            stream.Write((byte)ActiveSublass);//ActiveSublass = 237
            stream.Write(SubClassHasPoints);//SubClassHasPoints = 238
            stream.Write((uint)0);//unknow = 242
            stream.Write((ushort)FirstClass);//FirstClass = 246
            stream.Write((ushort)SecoundeClass);//SecoundeClass = 248
            stream.Write((ushort)Class);//Class = 250
            stream.Write((ushort)CountryID);//CountryID = 252
            if (Owner.Team != null)
                stream.Write((uint)Owner.Team.UID);//254
            else
                stream.Write(0);//254
            stream.Write(BattlePower);//BattlePower = 258
            stream.Write(JiangHuTalent);//JiangHuTalent = 262
            stream.Write(JiangHuActive);//JiangHuActive = 263
            stream.Write((byte)0);//unknow = 264
            if (OnMyOwnServer == false)
                stream.Write(ServerID);//ServerID = 265
            else
                stream.ZeroFill(2);
            stream.Write((uint)RealUID);//RealUID = 267
            stream.Write((byte)2);//CloneCount = 271
            stream.Write((ushort)0);//CloneID = 272
            stream.Write(0);//CloneOwner = 274
            if (InUnion)
            {
                stream.Write((uint)MyUnion.UID);//UnionUID = 278
                stream.Write((uint)ExploitsRank);//ExploitsRank = 282
                stream.Write((uint)Role.Instance.Union.Member.GetRank(UnionMemeber.Rank));//WingColor = 286     
                stream.Write((byte)(UnionMemeber.Rank == Instance.Union.Member.MilitaryRanks.Emperor ? 1 : 0));//MilitaryRank = 290
                stream.Write((byte)MyUnion.IsKingdom);//UnionKingdom = 291
            }
            else
            {
                stream.ZeroFill(4);
                stream.Write((uint)ExploitsRank);//ExploitsRank = 282
                stream.ZeroFill(6);
            }
            stream.Write(SpecialTitleID);//SpecialTitleID = 292
            stream.Write(SpecialTitleScore);//TitleScore = 296
            stream.Write(SpecialWingID);//WingID = 300
            stream.Write((uint)MainFlag);//MainFlag = 304
            stream.Write(0);//308
            stream.ZeroFill(5);
            if (OnMyOwnServer == false)//Name = 317
            {
                if (InUnion)
                    stream.Write(Name, string.Empty, ClanName, string.Empty, string.Empty, MyGuild != null ? MyGuild.GuildName : string.Empty, MyUnion.Name);
                else
                    stream.Write(Name, string.Empty, ClanName, string.Empty, string.Empty, MyGuild != null ? MyGuild.GuildName : string.Empty, string.Empty);
            }
            else
            {
                if (InUnion)
                    stream.Write(Name, string.Empty, ClanName, string.Empty, string.Empty, string.Empty, MyUnion.Name);
                else
                    stream.Write(Name, string.Empty, ClanName, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            stream.Finalize(Game.GamePackets.SpawnPlayer);
            return stream;
        }