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
            private FizzBuzz _fizzBuzz;

            [SetUp]
            public void Setup()
            {
                _fizzBuzz = new FizzBuzz();
            }

            [Test]
            public void これは失敗します()
            {
                //Assert.Fail();
            }

            [Test]
            public void _1を渡すと文字列1を返す()
            {
                Assert.AreEqual("1", _fizzBuzz.convert(1));
            }

            [Test]
            public void _2を渡すと文字列1を返す()
            {
                Assert.AreEqual("2", _fizzBuzz.convert(2));
            }

            [Test]
            public void _3の倍数のときは数の代わりにFizzに変換する__3を渡すと文字列Fizzを返す()
            {
                Assert.AreEqual("Fizz", _fizzBuzz.convert(3));
            }

            [Test]
            public void _5の倍数のときは数の代わりにBuzzに変換する_5を渡すと文字列Buzzを返す()
            {
                Assert.AreEqual("Buzz", _fizzBuzz.convert(5));
            }
        }

        

    }
}
