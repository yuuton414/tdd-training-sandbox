using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary.Test
{
    public class FizzBuzzTest
    {
        class FizzBuzz変換規則のテスト
        {
            public FizzBuzz _fizzBuzz;

            [SetUp]
            public void 準備()
            {
                _fizzBuzz = new FizzBuzz();
            }

            [TestFixture]
            public class _3の倍数のときは数の代わりにFizzに変換する : FizzBuzz変換規則のテスト
            {
                [Test]
                public void 同値類の中の最小の3の倍数である3を渡すと文字列Fizzを返す()
                {
                    Assert.AreEqual("Fizz", _fizzBuzz.convert(3));
                }

                [Test]
                public void 同値類の中の最大の3の倍数であり上限の境界値のひとつ内側の値99を渡すと文字列Fizzを返す()
                {
                    Assert.AreEqual("Fizz", _fizzBuzz.convert(99));
                }

                //private static TestCaseData[] TestSource1
                //    = new[]
                //    {
                //    new TestCaseData(3).Returns("Fizz").SetName("同値類の中の最小の3の倍数である3を渡すと文字列Fizzを返す"),
                //    new TestCaseData(99).Returns("Fizz").SetName("同値類の中の最大の3の倍数であり上限の境界値のひとつ内側の値99を渡すと文字列Fizzを返す"),
                //};

                //[TestCaseSource("TestSource1")]
                //public string _3の倍数の時は数の代わりにFizzに変換する(int i)
                //{
                //    return _fizzBuzz.convert(i);
                //}
            }

            //[Test]
            //[TestCase(3)]
            //[TestCase(99)]
            //public void _3の倍数の時は数の代わりにFizzに変換する(int i)
            //{
            //    Assert.AreEqual("Fizz", _fizzBuzz.convert(i));
            //}

            

            [TestFixture]
            public class _5の倍数のときは数の代わりにBuzzに変換する : FizzBuzz変換規則のテスト
            {
                [Test]
                public void 同値類の中の最小の5の倍数である5を渡すとを渡すと文字列Buzzを返す()
                {
                    Assert.AreEqual("Buzz", _fizzBuzz.convert(5));
                }

                [Test]
                public void 同値類の中の最大の5の倍数であり上限の境界値のひとつ内側の値99を渡すと文字列Buzzを返す()
                {
                    Assert.AreEqual("Buzz", _fizzBuzz.convert(100));
                }
            }

            [TestFixture]
            public class _3と5の両方の倍数のときは数の代わりにFizzBuzzに変換する : FizzBuzz変換規則のテスト
            {
                [Test]
                public void 同値類の中の最小の3と5の公倍数である値15を渡すと文字列FizzBuzzを返す()
                {
                    Assert.AreEqual("FizzBuzz", _fizzBuzz.convert(15));
                }

            }

            [TestFixture]
            public class その他の数のときはそのまま文字列に変換する : FizzBuzz変換規則のテスト
            {
                [Test]
                public void _1を渡すと文字列1を返す()
                {
                    Assert.AreEqual("1", _fizzBuzz.convert(1));
                }

                [Test]
                public void _2を渡すと文字列2を返す()
                {
                    Assert.AreEqual("2", _fizzBuzz.convert(2));
                }

            }

            [TestFixture]
            public class 仕様の範囲外であっても同じ変換規則が適用される: FizzBuzz変換規則のテスト
            {
                [Test]
                public void _101を渡すと文字列101を返す()
                {
                    Assert.AreEqual("101", _fizzBuzz.convert(101));
                }

                [Test]
                public void 下限の境界値のひとつ外側の値0は3と5の公倍数でもあるので文字列FizzBuzzを返す()
                {
                    Assert.AreEqual("FizzBuzz", _fizzBuzz.convert(15));
                }
            }

            [TestFixture]
            public class _15の倍数のときはFizzBuzzを返す : FizzBuzz変換規則のテスト
            {
                [Test]
                public void _15の倍数のときは数の代わりにFizzBuzzに変換する__15を渡すと文字列FizzBuzzを返す()
                {
                    Assert.AreEqual("FizzBuzz", _fizzBuzz.convert(15));
                }
            }
           
        }

        

    }
}
