﻿using DevExpress.ExpressApp.Model;

namespace Xpand.Persistent.Base.Logic.Model {
    public interface IModelLogicContexts : IModelNode {
        IModelExecutionContextsGroup ExecutionContextsGroup { get; }
        IModelActionExecutionContextGroup ActionExecutionContextGroup { get; }
        IModelViewContextsGroup ViewContextsGroup { get; }
        IModelFrameTemplateContextsGroup FrameTemplateContextsGroup { get; }
    }
}