using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	public class FOnGetItemChildrenDynamic : FRefDelegate
	{
		public FOnGetItemChildrenDynamic() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnGetItemChildrenDynamic() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Bind(UObject InObject, Delegate InDelegate) => FDelegateImplementation.FDelegate_BindImplementation(GarbageCollectionHandle, InObject.GarbageCollectionHandle, InDelegate);

		public void Execute(UObject Item, ref TArray<UObject> Children)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Item?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Children?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FDelegateImplementation.FDelegate_GenericExecute6Implementation(GarbageCollectionHandle, __InBuffer, __OutBuffer);

				Children = *(TArray<UObject>*)(__OutBuffer);

			}
		}

		public delegate void Delegate(UObject Item, ref TArray<UObject> Children);
	}
}
