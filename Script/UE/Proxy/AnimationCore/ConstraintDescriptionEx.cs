using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.ConstraintDescriptionEx")]
	public partial class FConstraintDescriptionEx : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.ConstraintDescriptionEx");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstraintDescriptionEx() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstraintDescriptionEx() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstraintDescriptionEx A, FConstraintDescriptionEx B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstraintDescriptionEx A, FConstraintDescriptionEx B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstraintDescriptionEx;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilterOptionPerAxis AxesFilterOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AxesFilterOption, __ReturnBuffer);

					return *(FFilterOptionPerAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AxesFilterOption, __InBuffer);
				}
			}
		}

		private static uint __AxesFilterOption = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}