using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EditorMapPerformanceTestDefinition")]
	public partial class FEditorMapPerformanceTestDefinition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EditorMapPerformanceTestDefinition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorMapPerformanceTestDefinition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorMapPerformanceTestDefinition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorMapPerformanceTestDefinition A, FEditorMapPerformanceTestDefinition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorMapPerformanceTestDefinition A, FEditorMapPerformanceTestDefinition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorMapPerformanceTestDefinition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath PerformanceTestmap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerformanceTestmap, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerformanceTestmap, __InBuffer);
				}
			}
		}

		public int TestTimer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TestTimer, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TestTimer, __InBuffer);
				}
			}
		}

		private static uint __PerformanceTestmap = 0;

		private static uint __TestTimer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}