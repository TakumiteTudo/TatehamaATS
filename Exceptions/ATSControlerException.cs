namespace TatehamaATS.Exceptions
{
    /// <summary>
    /// AF:ATS制御部未定義故障
    /// </summary>
    internal class ATSControlerException : ATSCommonException
    {
        /// <summary>
        /// AF:ATS制御部未定義故障
        /// </summary>
        public ATSControlerException(int place) : base(place)
        {
        }
        /// <summary>
        /// AF:ATS制御部未定義故障
        /// </summary>
        public ATSControlerException(int place, string message)
            : base(place, message)
        {
        }
        /// <summary>
        /// AF:ATS制御部未定義故障
        /// </summary>
        public ATSControlerException(int place, string message, Exception inner)
            : base(place, message, inner)
        {
        }
        public override string ToCode()
        {
            return Place.ToString() + "AF";
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
