using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SubobjectDataInterface
{
	[PathName("/Script/SubobjectDataInterface.ReparentSubobjectParams")]
	public partial class FReparentSubobjectParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SubobjectDataInterface.ReparentSubobjectParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FReparentSubobjectParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FReparentSubobjectParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FReparentSubobjectParams A, FReparentSubobjectParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FReparentSubobjectParams A, FReparentSubobjectParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FReparentSubobjectParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSubobjectDataHandle NewParentHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewParentHandle, __ReturnBuffer);

					return *(FSubobjectDataHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewParentHandle, __InBuffer);
				}
			}
		}

		public UBlueprint BlueprintContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintContext, __ReturnBuffer);

					return *(UBlueprint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintContext, __InBuffer);
				}
			}
		}

		public AActor ActorPreviewContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorPreviewContext, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorPreviewContext, __InBuffer);
				}
			}
		}

		private static uint __NewParentHandle = 0;

		private static uint __BlueprintContext = 0;

		private static uint __ActorPreviewContext = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}