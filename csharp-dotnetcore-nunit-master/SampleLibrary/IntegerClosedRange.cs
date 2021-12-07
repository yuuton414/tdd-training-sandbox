using System;

namespace SampleLibrary.Test
{
    public class IntegerClosedRange
    {
        private int LowerEndpoint { get; set; }
        private int UpperEndPoint { get; set; }

        public IntegerClosedRange(int v1, int v2)
        {

            if (!IsCreateClosedRange(v1, v2)) throw new Exception("上端点より大きい下端点を指定できません。");
            this.LowerEndpoint = v1;
            this.UpperEndPoint = v2;


        }

        public int GetLowerEndpoint()
        {
            return LowerEndpoint;
        }

        public int GetUpperEndPoint()
        {
            return UpperEndPoint;
        }

        public string ToStringDisplay()
        {
            return $"[{LowerEndpoint},{UpperEndPoint}]";
        }

        public bool IsCreateClosedRange(int initLowerEndpoint, int initUpperEndpoint)
        {
            return initLowerEndpoint < initUpperEndpoint;
        }

        public bool IsContain(int v)
        {
            return v >= LowerEndpoint && v <= UpperEndPoint;
        }

        public bool IsEqualRange(int targetLowerEndpoint, int targetUpperEndpoint)
        {
            return targetLowerEndpoint == LowerEndpoint &&  targetUpperEndpoint == UpperEndPoint;
        }

        public bool IsContainRange(int targetLowerEndpoint, int targetUpperEndpoint)
        {
            return targetLowerEndpoint >= LowerEndpoint &&
                targetLowerEndpoint <= UpperEndPoint &&
                targetLowerEndpoint <= targetUpperEndpoint &&
                targetUpperEndpoint >= LowerEndpoint &&
                targetUpperEndpoint <= UpperEndPoint;
                ;
        }
    }
}