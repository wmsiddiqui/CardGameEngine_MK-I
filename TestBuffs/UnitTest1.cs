using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCardClasses.Buffs.Applied_Buffs;

namespace TestBuffs
{
    [TestClass]
    public class TestSingletonBuffs
    {
        [TestMethod]
        public void TestStackability()
        {
            var unit = new TestCardClasses.Units.CustomUnit1();
            var buff1 = new TestBuff1();
            var buff2 = new TestBuff2();

            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff1, unit);
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff2, unit);

            Assert.AreEqual(2, unit.ApiAppliedBuffsExternalCall.Length);

            var buff12 = new TestBuff1();
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff12, unit);

            Assert.AreEqual(2, unit.ApiAppliedBuffsExternalCall.Length);

            var buff22 = new TestBuff2();
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff22, unit);
            Assert.AreEqual(3, unit.ApiAppliedBuffsExternalCall.Length);
        }

        [TestMethod]
        public void TestBuffRemoval()
        {
            var unit = new TestCardClasses.Units.CustomUnit1();
            var buff1 = new TestBuff1();
            var buff2 = new TestBuff2();

            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff1, unit);
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff2, unit);

            Assert.AreEqual(2, unit.ApiAppliedBuffsExternalCall.Length);

            var buff22 = new TestBuff2();
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff22, unit);
            Assert.AreEqual(3, unit.ApiAppliedBuffsExternalCall.Length);

            TestCardClasses.Buffs.BuffProcessor.RemoveBuff(buff1, unit);
            Assert.AreEqual(2, unit.ApiAppliedBuffsExternalCall.Length);

            TestCardClasses.Buffs.BuffProcessor.RemoveBuff(buff2, unit);
            Assert.AreEqual(1, unit.ApiAppliedBuffsExternalCall.Length);
            TestCardClasses.Buffs.BuffProcessor.AddBuff(buff2, unit);
            TestCardClasses.Buffs.BuffProcessor.RemoveBuff(buff2, unit, true);
            Assert.AreEqual(0, unit.ApiAppliedBuffsExternalCall.Length);
        }

        [TestMethod]
        public void TestUnitCreationStats()
        {
            var unit = new TestCardClasses.Units.CustomUnit1();

            Assert.AreEqual(5, unit.BaseHealth);
            Assert.AreEqual(5, unit.Health);
            Assert.AreEqual(2, unit.BaseAttack);
            Assert.AreEqual(2, unit.BaseSpeed);
            Assert.AreEqual(2, unit.BaseEnergyMax);
            Assert.AreEqual(2, unit.StartingEnergy);
            Assert.AreEqual(2, unit.Range);
            Assert.AreEqual(2, unit.Level);
        }

        [TestMethod]
        public void TestConditionalBuff()
        {
            var unit = new TestCardClasses.Units.CustomUnit1();
            var berserkerBuff = new BerserkerBuff();
            TestCardClasses.Buffs.BuffProcessor.AddBuff(berserkerBuff, unit);
            Assert.IsFalse(berserkerBuff.IsActive());
            unit.Health = 2;
            Assert.IsTrue(berserkerBuff.IsActive());            
        }

    }
}
