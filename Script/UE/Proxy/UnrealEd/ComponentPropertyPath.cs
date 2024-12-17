using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ComponentPropertyPath")]
	public partial class FComponentPropertyPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.ComponentPropertyPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FComponentPropertyPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FComponentPropertyPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FComponentPropertyPath A, FComponentPropertyPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FComponentPropertyPath A, FComponentPropertyPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FComponentPropertyPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<AActor> ParentOwningActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentOwningActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentOwningActor, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UActorComponent> LastResortComponentPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastResortComponentPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastResortComponentPtr, __InBuffer);
				}
			}
		}

		public TArray<FPropertyNameAndIndex> PropertyChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyChain, __ReturnBuffer);

					return *(TArray<FPropertyNameAndIndex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyChain, __InBuffer);
				}
			}
		}

		private static uint __ParentOwningActor = 0;

		private static uint __LastResortComponentPtr = 0;

		private static uint __PropertyChain = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}