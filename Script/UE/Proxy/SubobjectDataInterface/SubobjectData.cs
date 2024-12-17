using Script.CoreUObject;
using Script.Library;

namespace Script.SubobjectDataInterface
{
	[PathName("/Script/SubobjectDataInterface.SubobjectData")]
	public partial class FSubobjectData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SubobjectDataInterface.SubobjectData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubobjectData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubobjectData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubobjectData A, FSubobjectData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubobjectData A, FSubobjectData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubobjectData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UObject> WeakObjectPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeakObjectPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeakObjectPtr, __InBuffer);
				}
			}
		}

		public FSubobjectDataHandle Handle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __ReturnBuffer);

					return *(FSubobjectDataHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __InBuffer);
				}
			}
		}

		public FSubobjectDataHandle ParentObjectHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentObjectHandle, __ReturnBuffer);

					return *(FSubobjectDataHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentObjectHandle, __InBuffer);
				}
			}
		}

		public TArray<FSubobjectDataHandle> ChildrenHandles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildrenHandles, __ReturnBuffer);

					return *(TArray<FSubobjectDataHandle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildrenHandles, __InBuffer);
				}
			}
		}

		private static uint __WeakObjectPtr = 0;

		private static uint __Handle = 0;

		private static uint __ParentObjectHandle = 0;

		private static uint __ChildrenHandles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}