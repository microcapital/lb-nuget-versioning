using System;

namespace lb_nuget_versioning
{
    public class Class1
    {
        private int _count;

        public Class1()
        {
            _count = 2;
        }
        public int Count()
        {
            _count++;
            if(_count%2==0)
            return _count;
            return 1;
        }
    }
}
