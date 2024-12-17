using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentSpacePose")]
	public partial class FComponentSpacePose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ComponentSpacePose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FComponentSpacePose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FComponentSpacePose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FComponentSpacePose A, FComponentSpacePose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FComponentSpacePose A, FComponentSpacePose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FComponentSpacePose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTransform> Transforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transforms, __InBuffer);
				}
			}
		}

		public TArray<FName> Names
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Names, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Names, __InBuffer);
				}
			}
		}

		private static uint __Transforms = 0;

		private static uint __Names = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}