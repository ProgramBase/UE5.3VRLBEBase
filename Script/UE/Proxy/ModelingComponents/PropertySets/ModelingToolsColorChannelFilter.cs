using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.ModelingToolsColorChannelFilter")]
	public partial class FModelingToolsColorChannelFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.ModelingToolsColorChannelFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModelingToolsColorChannelFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModelingToolsColorChannelFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModelingToolsColorChannelFilter A, FModelingToolsColorChannelFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModelingToolsColorChannelFilter A, FModelingToolsColorChannelFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModelingToolsColorChannelFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bRed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRed, __InBuffer);
				}
			}
		}

		public bool bGreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bGreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bGreen, __InBuffer);
				}
			}
		}

		public bool bBlue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBlue, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBlue, __InBuffer);
				}
			}
		}

		public bool bAlpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAlpha, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAlpha, __InBuffer);
				}
			}
		}

		private static uint __bRed = 0;

		private static uint __bGreen = 0;

		private static uint __bBlue = 0;

		private static uint __bAlpha = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}