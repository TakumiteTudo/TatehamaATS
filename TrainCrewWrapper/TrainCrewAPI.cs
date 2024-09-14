namespace TrainCrewWrapper
{
    /// <summary>
    /// TrainCrewAPIクラス
    /// (シングルインスタンス)
    /// </summary>
    internal class TrainCrewAPI : ITrainCrewAPI, IDisposable
    {
        private static readonly TrainCrewAPI _instance = new TrainCrewAPI();
        private bool disposed = false; // Disposeが二度呼ばれないように管理するフラグ

        private TrainCrewAPI()
        {
            TrainCrew.TrainCrewInput.Init();
        }

        public static TrainCrewAPI Instance
        {
            get { return _instance; }
        }

        public void SetNotch(int notch)
        {
            TrainCrew.TrainCrewInput.SetNotch(notch);
        }

        public void SetNotch(int power, int brake)
        {
            TrainCrew.TrainCrewInput.SetNotch(power, brake);
        }

        public void SetBrakeSAP(float sap_kPa)
        {
            TrainCrew.TrainCrewInput.SetBrakeSAP(sap_kPa);
        }

        public void SetDeadman(int ch, bool holding)
        {
            TrainCrew.TrainCrewInput.SetDeadman(ch, holding);
        }

        public void SetPowerNotch(int power)
        {
            TrainCrew.TrainCrewInput.SetPowerNotch(power);
        }

        public void SetBrakeNotch(int brake)
        {
            TrainCrew.TrainCrewInput.SetBrakeNotch(brake);
        }

        public void SetATO_Notch(int notch)
        {
            TrainCrew.TrainCrewInput.SetATO_Notch(notch);
        }

        public void SetATO_Notch(int power, int brake)
        {
            TrainCrew.TrainCrewInput.SetATO_Notch(power, brake);
        }

        public void SetATO_PowerNotch(int power)
        {
            TrainCrew.TrainCrewInput.SetATO_PowerNotch(power);
        }

        public void SetATO_BrakeNotch(int brake)
        {
            TrainCrew.TrainCrewInput.SetATO_BrakeNotch(brake);
        }

        public void SetReverser(int dir)
        {
            TrainCrew.TrainCrewInput.SetReverser(dir);
        }

        public void SetButton(TrainCrew.InputAction action, bool on)
        {
            TrainCrew.TrainCrewInput.SetButton(action, on);
        }

        public void SetWiper(int state)
        {
            TrainCrew.TrainCrewInput.SetWiper(state);
        }

        public void RequestStaData()
        {
            TrainCrew.TrainCrewInput.RequestStaData();
        }

        public void RequestData(TrainCrew.DataRequest req)
        {
            TrainCrew.TrainCrewInput.RequestData(req);
        }

        public TrainCrew.TrainState GetTrainState()
        {
            return TrainCrew.TrainCrewInput.GetTrainState();
        }

        public TrainCrew.GameState GetGameState()
        {
            return TrainCrew.TrainCrewInput.gameState;
        }

        public List<TrainCrew.SignalInfo> GetSignals()
        {
            return TrainCrew.TrainCrewInput.signals;
        }

        public TrainCrew.TrainSwitch GetTrainSwitch()
        {
            return TrainCrew.TrainCrewInput.trainSwitch;
        }

        public string GetLastSigHash()
        {
            return TrainCrew.TrainCrewInput.lastSigHash;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  // ガベージコレクタによる二重解放を防ぐ
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    TrainCrew.TrainCrewInput.Dispose();
                }
                disposed = true;
            }
        }

        ~TrainCrewAPI()
        {
            Dispose(false);
        }
    }
}
