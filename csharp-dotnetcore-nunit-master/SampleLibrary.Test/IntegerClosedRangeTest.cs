using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary.Test
{
    public class IntegerClosedRangeTest
    {
        private IntegerClosedRange _integerClosedRange;
        [SetUp]
        public void 前準備()
        {
        }

        private void SetUpIntegerClosedRange(int initLowerEndpoint, int initUpperEndpoint)
        {
            _integerClosedRange = new IntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
        }

        [TestFixture]
        public class 渡した引数で初期化したIntegerClosedRangeクラスが生成され要素を返す : IntegerClosedRangeTest
        {
            [Test]
            [TestCase(3, 8, TestName = "3, 8で閉区間が生成され、下端点3を取得できる")]
            public void 渡した引数で初期化したIntegerClosedRangeクラスの下端点を取得できる(int initLowerEndpoint, int initUpperEndpoint)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(initLowerEndpoint, _integerClosedRange.GetLowerEndpoint());
            }

            [Test]
            [TestCase(3, 8, TestName = "3, 8で閉区間が生成され、上端点8を取得できる")]
            public void 渡した引数で初期化したIntegerClosedRangeクラスの上端点を取得できる(int initLowerEndpoint, int initUpperEndpoint)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(initUpperEndpoint, _integerClosedRange.GetUpperEndPoint());
            }
        }

        [TestFixture]
        public class 渡した引数で初期化したIntegerClosedRangeクラスが生成され文字列表現を返す: IntegerClosedRangeTest
        {
            [Test]
            [TestCase(3, 8, "[3,8]")]
            [TestCase(9, 15, "[9,15]")]
            public void _渡した引数で文字列表現で返す(int initLowerEndpoint, int initUpperEndpoint, string expectedClosedRangeString)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(expectedClosedRangeString, _integerClosedRange.ToStringDisplay());
            }
        }

        [TestFixture]
        public class 渡した引数で上端点より下端点が大きい場合は閉区間は作れない: IntegerClosedRangeTest
        {
            [Test]
            [TestCase(8, 3, "上端点より大きい下端点を指定できません。")]
            [TestCase(3, 3, "上端点より大きい下端点を指定できません。")]
            public void _渡した引数の上端点が下端点より小さい場合エラーが発生する(int initLowerEndpoint, int initUpperEndpoint, string expectedClosedRangeString)
            {
                try
                {
                    SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                    Assert.Fail();
                }
                catch (Exception e)
                {
                    Assert.AreEqual(expectedClosedRangeString, e.Message);
                }
            }
           
        }

        [TestFixture]
        public class 指定した整数が生成された閉区間に含んでいるとtrue_含んでいないとfalseを返す : IntegerClosedRangeTest
        {
            [Test]
            [TestCase(3, 8, 3, true)]
            [TestCase(3, 8, 8, true)]
            public void 指定した整数が生成された閉区間に含んでいるとtrueを返す(int initLowerEndpoint, int initUpperEndpoint, int targetPoint, bool expectedIsContain)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(expectedIsContain, _integerClosedRange.IsContain(targetPoint));
            }

            [Test]
            [TestCase(3, 8, 2, false)]
            [TestCase(3, 8, 9, false)]
            public void 指定した整数が生成された閉区間に含んでいないとfalseを返す(int initLowerEndpoint, int initUpperEndpoint, int targetPoint, bool expectedIsContain)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(expectedIsContain, _integerClosedRange.IsContain(targetPoint));
            }
        }

        [TestFixture]
        public class 生成された区間と指定した閉区間は等価であればtrue_等価でなければfalseを返す: IntegerClosedRangeTest
        {
            [Test]
            [TestCase(3, 8, 3, 8, true)]
            public void 指定区間が等価であればtrueを返す(int initLowerEndpoint, int initUpperEndpoint, int targetLowerEndpoint, int targetUpperEndpoint, bool expectedIsEqual)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(expectedIsEqual, _integerClosedRange.IsEqualRange(targetLowerEndpoint, targetUpperEndpoint));
            }

            [Test]
            [TestCase(3, 8, 3, 9, false)]
            [TestCase(3, 8, 2, 8, false)]
            [TestCase(3, 8, 2, 9, false)]
            public void 指定区間が等価でなければfalseを返す(int initLowerEndpoint, int initUpperEndpoint, int targetLowerEndpoint, int targetUpperEndpoint, bool expectedIsEqual)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(expectedIsEqual, _integerClosedRange.IsEqualRange(targetLowerEndpoint, targetUpperEndpoint));
            }
        }

        [TestFixture]
        public class 生成された区間が別の閉区間と完全に含まれていればtrue_含まれていなければfalseを返す: IntegerClosedRangeTest
        {
            [Test]
            [TestCase(3, 8, 3, 8, true, TestName ="下端上端の境界値の場合trueを返す")]
            [TestCase(3, 8, 4, 8, true, TestName = "下端境界値+1, 上端境界値の場合trueを返す")]
            [TestCase(3, 8, 4, 7, true, TestName = "下端境界値+1, 上端境界値-1の場合trueを返す")]
            [TestCase(3, 8, 3, 7, true, TestName = "下端境界値, 上端境界値-1の場合trueを返す")]
            public void 指定した引数は完全に含まれているのでtrueを返す(int initLowerEndpoint, int initUpperEndpoint, int targetLowerEndpoint, int targetUpperEndpoint, bool expectedIsEqual)
            {
                SetUpIntegerClosedRange(initLowerEndpoint, initUpperEndpoint);
                Assert.AreEqual(true, _integerClosedRange.IsContainRange(targetLowerEndpoint, targetUpperEndpoint));
            }
        }

    }
}
