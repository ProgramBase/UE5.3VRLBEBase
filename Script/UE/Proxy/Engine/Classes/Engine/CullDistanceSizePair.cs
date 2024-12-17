using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CullDistanceSizePair")]
	public partial class FCullDistanceSizePair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CullDistanceSizePair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCullDistanceSizePair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCullDistanceSizePair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCullDistanceSizePair A, FCullDistanceSizePair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCullDistanceSizePair A, FCullDistanceSizePair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCullDistanceSizePair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Size
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Size, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Size, __InBuffer);
				}
			}
		}

		public float CullDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CullDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CullDistance, __InBuffer);
				}
			}
		}

		private static uint __Size = 0;

		private static uint __CullDistance = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}