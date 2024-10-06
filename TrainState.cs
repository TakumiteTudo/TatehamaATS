﻿using TatehamaATS.ATSControler;
using TatehamaATS.Database;
using TatehamaATS.Exceptions;
using TatehamaATS.ATSOperation;
using TrainCrew;

namespace TatehamaATS
{
    enum DiaType
    {
        /// <summary>
        /// 現在ダイヤ
        /// </summary>
        Normal,
        /// <summary>
        /// 92年ダイヤ
        /// </summary>
        OldEdition
    }

    static internal class TrainState
    {
        /// <summary>
        /// ダイヤ選択
        /// </summary>
        static public DiaType DiaType;

        /// <summary>
        /// 現在ゲーム状態
        /// </summary>
        static public GameScreen gameScreen;
        /// <summary>
        /// 自車速度
        /// </summary>
        static public float? TrainSpeed;
        /// <summary>
        /// 自車手動P段
        /// </summary>
        static public int TrainPnotch;
        /// <summary>
        /// 自車手動B段
        /// </summary>
        static public int TrainBnotch;
        /// <summary>
        /// 自車列番
        /// </summary>
        static public string? TrainDiaName;
        /// <summary>
        /// 自車両数
        /// </summary>
        static public int? TrainCar;
        /// <summary>
        /// 自車長さ
        /// </summary>
        static public int? TrainLength;
        /// <summary>
        /// 自車車種名
        /// </summary>
        static public string? TrainName;
        /// <summary>
        /// 現在時刻
        /// </summary>
        static public TimeSpan NowTime;
        /// <summary>
        /// 前閉塞情報
        /// </summary>
        static public TrackCircuitInfo? BeforeTrack;
        /// <summary>
        /// 現在閉塞情報
        /// </summary>
        static public TrackCircuitInfo? OnTrack;
        /// <summary>
        /// 現在閉塞インデックス
        /// </summary>
        static public int? OnTrackIndex;
        /// <summary>
        /// 次閉塞情報
        /// </summary>
        static public TrackCircuitInfo? NextTrack;
        /// <summary>
        /// 次々閉塞情報
        /// </summary>
        static public TrackCircuitInfo? NextNextTrack;
        /// <summary>
        /// 路線データベース
        /// </summary>
        static public RouteDatabase? RouteDatabase;
        /// <summary>
        /// 路線データベース長さ
        /// </summary>
        static public int? RouteDatabaseCount;
        /// <summary>
        /// 本体表示器
        /// </summary>
        static public ATSDisplay? TC_ATSDisplay;
        /// <summary>
        /// 合計表示器
        /// </summary>
        static public ATSDisplay? ATSDisplay;
        /// <summary>
        /// LED試験
        /// </summary>
        static public bool ATSLEDTest;
        /// <summary>
        /// 信号機地上子情報
        /// </summary>
        static public List<SignalBeaconsInfo>? SignalBeaconsList;
        /// <summary>
        /// 結合した信号機地上子Index
        /// </summary>
        static public int CoupledSignalBeaconIndex;

        /// <summary>
        /// 列番変更
        /// </summary>
        static public bool chengeDiaName;

        /// <summary>
        /// ATS1系状態
        /// </summary>
        static public ATSState? ATS1State;
        /// <summary>
        /// ATS2系状態
        /// </summary>
        static public ATSState? ATS2State;

        /// <summary>
        /// 完全初期化
        /// </summary>
        static public void init()
        {
            TrainSpeed = 0f;
            TrainName = null;
            BeforeTrack = null;
            OnTrack = null;
            NextTrack = null;
            RouteDatabase = null;
            RouteDatabaseCount = 0;
            TC_ATSDisplay = null;
            ATSDisplay = new ATSDisplay("", "", [""]);
            OnTrackIndex = null;
            SignalBeaconsList = null;
            CoupledSignalBeaconIndex = -1;
            ATS1State = null;
            ATS2State = null;
        }
    }
}