using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.UMG;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetAnimation_DEPRECATED")]
	public partial class FWidgetAnimation_DEPRECATED : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.WidgetAnimation_DEPRECATED");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetAnimation_DEPRECATED() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetAnimation_DEPRECATED() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetAnimation_DEPRECATED A, FWidgetAnimation_DEPRECATED B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetAnimation_DEPRECATED A, FWidgetAnimation_DEPRECATED B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetAnimation_DEPRECATED;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieScene MovieScene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MovieScene, __ReturnBuffer);

					return *(UMovieScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MovieScene, __InBuffer);
				}
			}
		}

		public TArray<FWidgetAnimationBinding> AnimationBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimationBindings, __ReturnBuffer);

					return *(TArray<FWidgetAnimationBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimationBindings, __InBuffer);
				}
			}
		}

		private static uint __MovieScene = 0;

		private static uint __AnimationBindings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}