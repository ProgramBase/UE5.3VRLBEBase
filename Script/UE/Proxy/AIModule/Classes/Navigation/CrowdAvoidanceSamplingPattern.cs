using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.CrowdAvoidanceSamplingPattern")]
	public partial class FCrowdAvoidanceSamplingPattern : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.CrowdAvoidanceSamplingPattern");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCrowdAvoidanceSamplingPattern() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCrowdAvoidanceSamplingPattern() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCrowdAvoidanceSamplingPattern A, FCrowdAvoidanceSamplingPattern B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCrowdAvoidanceSamplingPattern A, FCrowdAvoidanceSamplingPattern B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCrowdAvoidanceSamplingPattern;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<float> Angles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Angles, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Angles, __InBuffer);
				}
			}
		}

		public TArray<float> Radii
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Radii, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Radii, __InBuffer);
				}
			}
		}

		private static uint __Angles = 0;

		private static uint __Radii = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}