using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MontageBlendSettings")]
	public partial class FMontageBlendSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MontageBlendSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMontageBlendSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMontageBlendSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMontageBlendSettings A, FMontageBlendSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMontageBlendSettings A, FMontageBlendSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMontageBlendSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UBlendProfile BlendProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendProfile, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendProfile, __InBuffer);
				}
			}
		}

		public FAlphaBlendArgs Blend
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Blend, __ReturnBuffer);

					return *(FAlphaBlendArgs*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Blend, __InBuffer);
				}
			}
		}

		public EMontageBlendMode BlendMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendMode, __ReturnBuffer);

					return *(EMontageBlendMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendMode, __InBuffer);
				}
			}
		}

		private static uint __BlendProfile = 0;

		private static uint __Blend = 0;

		private static uint __BlendMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}