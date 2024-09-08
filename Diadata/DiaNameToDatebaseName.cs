﻿//括弧やセミコロン、カンマなどの数等に注意する。
//また、辞書以外を弄らないこと。
namespace TatehamaATS.Diadata
{
    internal class DiaNameToDatebaseName
    {
        private Dictionary<string, string> 列番変換辞書;
        public DiaNameToDatebaseName()
        {
            列番変換辞書 = new Dictionary<string, string>{   
                //--編集可能ここから     
                //通常使用部分       
                {"551", "回451"},
                {"581C", "581"},
                {"592", "592C"}, 

                //運転会用部分
                //通常列番
                {"回1013A", "回1105A"},
                {"1112A", "1204A"},
                {"1017A", "1107A"},
                {"回1216A", "回1306A"},
                {"回1217A", "回1105A"},
                {"1316A", "1204A"},
                {"1075", "1261"},
                {"1174", "1260"},
                {"1275", "1261"},
                {"1274", "1166"},
                {"1060", "1166"},
                {"1161", "1267"},
                {"1183C", "1283C"},
                {"1182C", "1282C"},
                {"1168C", "1284C"},
                {"1169C", "1285C"},
                {"1268C", "1284C"},
                {"1269C", "1285C"},
                {"1011A", "1209A"},
                {"1110A", "1204A"},
                {"1103A", "1209A"},
                {"回1104A", "回1306A"},
                {"1164", "1260"},
                {"1165", "1261"},
                {"1264", "1260"},
                {"1167", "1261"},
                {"1185C", "1285C"},
                {"1184C", "1284C"},

                //試運転
                {"回7190", "回862"},
                {"回7191", "回607A"},
                {"回7290", "回862"},
                {"回7291", "回607A"},

                //新だんじり
                {"回7281", "回607A"},
                {"回1195", "回607A"},
                {"回1181X", "回607A"},
                {"回1281X", "回607A"},
                {"回7181", "回771"},
                {"回7283", "回771"},
                {"回1181", "回771"},
                {"回1281", "回771"},
                {"6981K", "3643K"},
                {"7185K", "3643K"},
                {"7083K", "3643K"},
                {"7280K", "796K"},
                {"1194K", "796K"},
                {"7281B", "回607A"},
                {"1195B", "回607A"},
                {"1181B", "回607A"},
                {"1281B", "回607A"},
                {"7180C", "2084C"},
                {"7282C", "2084C"},
                {"1180C", "2084C"},
                {"1280C", "2084C"},


                //--編集可能ここまで
            };
        }

        public string ChengeDiaName(string DiaName)
        {
            if (列番変換辞書.ContainsKey(DiaName))
            {
                return 列番変換辞書[DiaName];
            }
            return DiaName;
        }
    }
}