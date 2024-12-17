using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MirrorTableFindReplaceExpressions")]
	public partial class UMirrorTableFindReplaceExpressions : UObject, IStaticClass
	{
		public TArray<FMirrorFindReplaceExpression> FindReplaceExpressions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FindReplaceExpressions, __ReturnBuffer);

					return *(TArray<FMirrorFindReplaceExpression>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FindReplaceExpressions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MirrorTableFindReplaceExpressions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FindReplaceExpressions = 0;
	}
}