using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	public class FPyTestDelegate : FDelegate<Func<int, int>>
	{
		public FPyTestDelegate() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FPyTestDelegate() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public int Execute(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FDelegateImplementation.FDelegate_PrimitiveExecute3Implementation(GarbageCollectionHandle, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}
	}
}
