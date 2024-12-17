using Script.CoreUObject;
using Script.Reflection.Property;
using Script.Library;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieSceneKeyStructType")]
	public partial class UMovieSceneKeyStructType : UScriptStruct, IStaticClass
	{
		public TFieldPath<FArrayProperty> SourceTimesProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceTimesProperty, __ReturnBuffer);

					return *(TFieldPath<FArrayProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceTimesProperty, __InBuffer);
				}
			}
		}

		public TFieldPath<FArrayProperty> SourceValuesProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceValuesProperty, __ReturnBuffer);

					return *(TFieldPath<FArrayProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceValuesProperty, __InBuffer);
				}
			}
		}

		public TFieldPath<FStructProperty> DestTimeProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DestTimeProperty, __ReturnBuffer);

					return *(TFieldPath<FStructProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DestTimeProperty, __InBuffer);
				}
			}
		}

		public TFieldPath<FProperty> DestValueProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DestValueProperty, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DestValueProperty, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Sequencer.MovieSceneKeyStructType");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceTimesProperty = 0;

		private static uint __SourceValuesProperty = 0;

		private static uint __DestTimeProperty = 0;

		private static uint __DestValueProperty = 0;
	}
}