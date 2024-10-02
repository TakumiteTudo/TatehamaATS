//括弧やセミコロン、ダブルクォーテーション、breakの忘れなどの数等に注意する。
//構文に関するコメントを書く。
//また、switch構文以外を弄らないこと。

namespace TatehamaATS.Diadata
{
    internal class DiaNameTrack
    {
        public void ChengeTrack(string 列番)
        {
            switch (列番)
            {
                case "1017A":
                    //元シナリオ：列番不定　大道寺　→館　浜　／内容：着線２番振替
                    TrainState.RouteDatabase.CircuitList[35].ChengeName("館浜下り場内1LB");
                    break;

                //だんじり・試運転
                case "回7281":
                case "7281B":
                case "回1195":
                case "1195B":
                case "回1181X":
                case "1181B":
                case "回1281X":
                case "1281B":
                case "回7191":
                case "回7291":
                    //元シナリオ：列番不定　江ノ原検→館　浜　／内容：着線２番振替 
                    TrainState.RouteDatabase.CircuitList[34].ChengeName("館浜下り場内1LB");
                    break;

                case "7180C":
                case "7282C":
                case "1180C":
                case "1280C":
                case "回7190":
                case "回7290":
                    //元シナリオ：列番不定　館　浜　→発車共通／内容：発線２番振替 
                    TrainState.RouteDatabase.CircuitList[0].ChengeName("館浜下り場内1LB");
                    TrainState.RouteDatabase.CircuitList[1].ChengeName("館浜上り出発2R");
                    break;

                //92年 4300展示回送用　
                case "回7001":
                    //元シナリオ：回 607A　江ノ原検→館　浜　／内容：着線３番振替 
                    TrainState.RouteDatabase.CircuitList[34].ChengeName("館浜下り場内1LC");
                    break;
                case "回7200":
                    //元シナリオ：回 862 　館　浜　→江ノ原検／内容：発線３番振替 
                    TrainState.RouteDatabase.CircuitList[0].ChengeName("館浜下り場内1LB");
                    TrainState.RouteDatabase.CircuitList[1].ChengeName("館浜上り出発3R");
                    break;

            }
        }
    }
}