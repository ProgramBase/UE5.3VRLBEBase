using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.DirectoryWidgetCompilerOptions")]
	public partial class FDirectoryWidgetCompilerOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.DirectoryWidgetCompilerOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDirectoryWidgetCompilerOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDirectoryWidgetCompilerOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDirectoryWidgetCompilerOptions A, FDirectoryWidgetCompilerOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDirectoryWidgetCompilerOptions A, FDirectoryWidgetCompilerOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDirectoryWidgetCompilerOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDirectoryPath Directory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Directory, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Directory, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<UWidgetBlueprint>> IgnoredWidgets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IgnoredWidgets, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<UWidgetBlueprint>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IgnoredWidgets, __InBuffer);
				}
			}
		}

		public FWidgetCompilerOptions Options
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Options, __ReturnBuffer);

					return *(FWidgetCompilerOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Options, __InBuffer);
				}
			}
		}

		private static uint __Directory = 0;

		private static uint __IgnoredWidgets = 0;

		private static uint __Options = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}