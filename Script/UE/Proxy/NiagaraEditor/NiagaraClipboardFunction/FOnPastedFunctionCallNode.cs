using System;
using Script.CoreUObject;
using Script.Library;
using Script.NiagaraEditor;

namespace Script.NiagaraEditor.NiagaraClipboardFunction
{
	public class FOnPastedFunctionCallNode : FDelegate<Action<UNiagaraNodeFunctionCall>>
	{
		public FOnPastedFunctionCallNode() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnPastedFunctionCallNode() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(UNiagaraNodeFunctionCall PastedFunctionCall)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PastedFunctionCall?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
