using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyExprMatch")]
	public partial class UEditableGameplayTagQueryExpression_AnyExprMatch : UEditableGameplayTagQueryExpression, IStaticClass
	{
		public TArray<UEditableGameplayTagQueryExpression> Expressions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Expressions, __ReturnBuffer);

					return *(TArray<UEditableGameplayTagQueryExpression>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Expressions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyExprMatch");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Expressions = 0;
	}
}