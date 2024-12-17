using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.NavigationSimulationArguments")]
	public partial class FNavigationSimulationArguments : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.NavigationSimulationArguments");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNavigationSimulationArguments() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNavigationSimulationArguments() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNavigationSimulationArguments A, FNavigationSimulationArguments B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNavigationSimulationArguments A, FNavigationSimulationArguments B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNavigationSimulationArguments;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int UserIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserIndex, __InBuffer);
				}
			}
		}

		public ENavigationGenesis NavigationGenesis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NavigationGenesis, __ReturnBuffer);

					return *(ENavigationGenesis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NavigationGenesis, __InBuffer);
				}
			}
		}

		public EUINavigation UINavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UINavigation, __ReturnBuffer);

					return *(EUINavigation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UINavigation, __InBuffer);
				}
			}
		}

		public bool bOverrideUINavigation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideUINavigation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideUINavigation, __InBuffer);
				}
			}
		}

		public bool bShowPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowPreview, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowPreview, __InBuffer);
				}
			}
		}

		private static uint __UserIndex = 0;

		private static uint __NavigationGenesis = 0;

		private static uint __UINavigation = 0;

		private static uint __bOverrideUINavigation = 0;

		private static uint __bShowPreview = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}