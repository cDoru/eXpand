﻿using System;
using System.Collections.Generic;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using Xpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using Xpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.Miscellaneous.Sequence {
    public class AttributeRegistrator : Xpand.ExpressApp.Core.AttributeRegistrator {
        private const string SequenceCustomer_DetailView = "SequenceCustomer_DetailView";
        public override IEnumerable<Attribute> GetAttributes(ITypeInfo typesInfo) {
            if (typesInfo.Type != typeof(SequenceCustomer)) yield break;
            yield return new AdditionalViewControlsRuleAttribute(Captions.ViewMessage + " " + Captions.HeaderSequence, "1=1", "1=1", Captions.ViewMessageSequence, Position.Bottom) { ViewType = ViewType.DetailView, View = SequenceCustomer_DetailView };
            yield return new AdditionalViewControlsRuleAttribute(Captions.Header + " " + Captions.HeaderSequence, "1=1", "1=1", Captions.HeaderSequence, Position.Top) { ViewType = ViewType.DetailView, View = SequenceCustomer_DetailView };
            yield return new XpandNavigationItemAttribute(Captions.Miscellaneous + "Sequence Numbers", SequenceCustomer_DetailView, "Name='Benjamin CISCO'");
        }
    }
}