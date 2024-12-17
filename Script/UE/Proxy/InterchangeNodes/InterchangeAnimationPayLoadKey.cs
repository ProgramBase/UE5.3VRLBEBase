using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeAnimationPayLoadKey")]
	public partial class FInterchangeAnimationPayLoadKey : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeNodes.InterchangeAnimationPayLoadKey");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeAnimationPayLoadKey() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeAnimationPayLoadKey() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeAnimationPayLoadKey A, FInterchangeAnimationPayLoadKey B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeAnimationPayLoadKey A, FInterchangeAnimationPayLoadKey B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeAnimationPayLoadKey;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString UniqueId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UniqueId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UniqueId, __InBuffer);
				}
			}
		}

		public EInterchangeAnimationPayLoadType Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(EInterchangeAnimationPayLoadType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		private static uint __UniqueId = 0;

		private static uint __Type = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}