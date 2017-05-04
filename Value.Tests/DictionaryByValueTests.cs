﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;
using Value.Shared;

namespace Value.Tests
{
    [TestFixture]
    public class DictionaryByValueTests
    {
        [Test]
        public void Should_consider_two_instances_with_same_elements_inserted_in_same_order_Equals()
        {
            var dico1 = new Dictionary<int, string>() { {1, "uno" }, { 4, "quatro" }, { 3, "tres" } };
            var dico2 = new Dictionary<int, string>() { { 1, "uno" }, { 4, "quatro" }, { 3, "tres" } };

            var byValue1 = new DictionaryByValue<int, string>(dico1);
            var byValue2 = new DictionaryByValue<int, string>(dico2);

            Check.That(dico1).IsNotEqualTo(dico2);
            Check.That(byValue1).IsEqualTo(byValue2);
        }

        [Test]
        public void Should_consider_two_instances_with_same_elements_inserted_in_different_order_Equals()
        {
            var dico1 = new Dictionary<int, string>() { {1, "uno" }, { 4, "quatro" }, { 3, "tres" } };
            var dico2 = new Dictionary<int, string>() { { 1, "uno" }, { 3, "tres" }, { 4, "quatro" } };

            var byValue1 = new DictionaryByValue<int, string>(dico1);
            var byValue2 = new DictionaryByValue<int, string>(dico2);

            Check.That(dico1).IsNotEqualTo(dico2);
            Check.That(byValue1).IsEqualTo(byValue2);
        }
    }
}
