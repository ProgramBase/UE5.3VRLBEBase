using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendGraphClass")]
	public partial class FMetasoundFrontendGraphClass : FMetasoundFrontendClass, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendGraphClass");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendGraphClass()
		{
		}

		public static bool operator ==(FMetasoundFrontendGraphClass A, FMetasoundFrontendGraphClass B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendGraphClass A, FMetasoundFrontendGraphClass B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendGraphClass;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendGraph Graph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Graph, __ReturnBuffer);

					return *(FMetasoundFrontendGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Graph, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendGraphClassPresetOptions PresetOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PresetOptions, __ReturnBuffer);

					return *(FMetasoundFrontendGraphClassPresetOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PresetOptions, __InBuffer);
				}
			}
		}

		private static uint __Graph = 0;

		private static uint __PresetOptions = 0;

	}
}