namespace TrainCrewWrapper
{
    /// <summary>
    /// ITrainCrewAPIインターフェース
    /// </summary>
    internal interface ITrainCrewAPI
    {
        void SetNotch(int notch);
        void SetNotch(int power, int brake);
        void SetBrakeSAP(float sap_kPa);
        void SetDeadman(int ch, bool holding);
        void SetPowerNotch(int power);
        void SetBrakeNotch(int brake);
        void SetATO_Notch(int notch);
        void SetATO_Notch(int power, int brake);
        void SetATO_PowerNotch(int power);
        void SetATO_BrakeNotch(int brake);
        void SetReverser(int dir);
        void SetButton(TrainCrew.InputAction action, bool on);
        void SetWiper(int state);
        void RequestStaData();
        void RequestData(TrainCrew.DataRequest req);
        TrainCrew.TrainState GetTrainState();
        TrainCrew.GameState GetGameState();
        List<TrainCrew.SignalInfo> GetSignals();
        TrainCrew.TrainSwitch GetTrainSwitch();
        string GetLastSigHash();
    }
}
