using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.SwitchActor")]
	public partial class ASwitchActor : AActor, IStaticClass
	{
		public USceneComponent SceneComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SceneComponent, __InBuffer);
				}
			}
		}

		public int LastSelectedOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastSelectedOption, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastSelectedOption, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.SwitchActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SelectOption(int OptionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = OptionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SelectOption, __InBuffer);
			}
		}

		public virtual int GetSelectedOption()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSelectedOption, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<AActor> GetOptions()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOptions, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		private static uint __SceneComponent = 0;

		private static uint __LastSelectedOption = 0;

		private static uint __SelectOption = 0;

		private static uint __GetSelectedOption = 0;

		private static uint __GetOptions = 0;
	}
}