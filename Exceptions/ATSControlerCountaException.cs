namespace TatehamaATS.Exceptions
{
    /// <summary>
    /// AE:ATS制御部カウンタ異常
    /// </summary>
    internal class ATSControlerCountaException : ATSCommonException
    {
        /// <summary>
        /// AE:ATS制御部カウンタ異常
        /// </summary>
        public ATSControlerCountaException(int place) : base(place)
        {
        }
        /// <summary>
        /// AE:ATS制御部カウンタ異常
        /// </summary>
        public ATSControlerCountaException(int place, string message)
            : base(place, message)
        {
        }
        /// <summary>
        /// AE:ATS制御部カウンタ異常
        /// </summary>
        public ATSControlerCountaException(int place, string message, Exception inner)
            : base(place, message, inner)
        {
        }
        public override string ToCode()
        {
            return Place.ToString() + "AE";
        }
        public override ResetConditions ResetCondition()
        {
            return ResetConditions.PowerReset;
        }
        public override OutputBrake ToBrake()
        {
            return OutputBrake.None;
        }
    }
}
