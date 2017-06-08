using System;

namespace TupleSandbox
{
    class MdlDateTime
    {
        private DateTime _datetime;

        public MdlDateTime(DateTime inDateTime)
        {
            _datetime = inDateTime;
        }

        // out parameter names here don't matter.  They are only used within the Deconstruct method.
        public void Deconstruct(out int temp1, out int temp2, out int temp3)
        {
            temp1 = _datetime.Hour;
            temp2 = _datetime.Minute;
            temp3 = _datetime.Second;
        }
    }
}