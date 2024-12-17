using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StrataMaterialInfo")]
	public partial class FStrataMaterialInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StrataMaterialInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStrataMaterialInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStrataMaterialInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStrataMaterialInfo A, FStrataMaterialInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStrataMaterialInfo A, FStrataMaterialInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStrataMaterialInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ushort ShadingModelField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShadingModelField, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShadingModelField, __InBuffer);
				}
			}
		}

		public byte bHasShadingModelFromExpression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasShadingModelFromExpression, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasShadingModelFromExpression, __InBuffer);
				}
			}
		}

		public ulong ConnectedPropertyMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConnectedPropertyMask, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConnectedPropertyMask, __InBuffer);
				}
			}
		}

		public TArray<USubsurfaceProfile> SubsurfaceProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubsurfaceProfiles, __ReturnBuffer);

					return *(TArray<USubsurfaceProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubsurfaceProfiles, __InBuffer);
				}
			}
		}

		public TArray<USpecularProfile> SpecularProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpecularProfiles, __ReturnBuffer);

					return *(TArray<USpecularProfile>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpecularProfiles, __InBuffer);
				}
			}
		}

		private static uint __ShadingModelField = 0;

		private static uint __bHasShadingModelFromExpression = 0;

		private static uint __ConnectedPropertyMask = 0;

		private static uint __SubsurfaceProfiles = 0;

		private static uint __SpecularProfiles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}