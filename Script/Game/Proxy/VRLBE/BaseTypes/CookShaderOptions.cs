using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.CookShaderOptions")]
	public partial class FCookShaderOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.CookShaderOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCookShaderOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCookShaderOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCookShaderOptions A, FCookShaderOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCookShaderOptions A, FCookShaderOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCookShaderOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bSharedShaderLibrary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSharedShaderLibrary, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSharedShaderLibrary, __InBuffer);
				}
			}
		}

		public bool bNativeShader
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNativeShader, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNativeShader, __InBuffer);
				}
			}
		}

		public EShaderLibNameRule ShaderNameRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShaderNameRule, __ReturnBuffer);

					return *(EShaderLibNameRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShaderNameRule, __InBuffer);
				}
			}
		}

		public FString CustomShaderName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomShaderName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomShaderName, __InBuffer);
				}
			}
		}

		public FString ShaderLibMountPointRegular
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShaderLibMountPointRegular, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShaderLibMountPointRegular, __InBuffer);
				}
			}
		}

		private static uint __bSharedShaderLibrary = 0;

		private static uint __bNativeShader = 0;

		private static uint __ShaderNameRule = 0;

		private static uint __CustomShaderName = 0;

		private static uint __ShaderLibMountPointRegular = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}