using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GraphReference")]
	public partial class FGraphReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.GraphReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGraphReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGraphReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGraphReference A, FGraphReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGraphReference A, FGraphReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGraphReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UEdGraph MacroGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MacroGraph, __ReturnBuffer);

					return *(UEdGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MacroGraph, __InBuffer);
				}
			}
		}

		public UBlueprint GraphBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GraphBlueprint, __ReturnBuffer);

					return *(UBlueprint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GraphBlueprint, __InBuffer);
				}
			}
		}

		public FGuid GraphGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GraphGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GraphGuid, __InBuffer);
				}
			}
		}

		private static uint __MacroGraph = 0;

		private static uint __GraphBlueprint = 0;

		private static uint __GraphGuid = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}