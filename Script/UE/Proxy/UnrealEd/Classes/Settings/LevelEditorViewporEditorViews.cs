using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditorViewporEditorViews")]
	public partial class FLevelEditorViewporEditorViews : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LevelEditorViewporEditorViews");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelEditorViewporEditorViews() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelEditorViewporEditorViews() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelEditorViewporEditorViews A, FLevelEditorViewporEditorViews B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelEditorViewporEditorViews A, FLevelEditorViewporEditorViews B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelEditorViewporEditorViews;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FLevelViewportInfo> LevelViewportsInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LevelViewportsInfo, __ReturnBuffer);

					return *(TArray<FLevelViewportInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LevelViewportsInfo, __InBuffer);
				}
			}
		}

		private static uint __LevelViewportsInfo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}