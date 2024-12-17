using Script.CoreUObject;
using Script.Library;
using Script.TypedElementFramework;
using Script.TypedElementRuntime;

namespace Script.Engine
{
	[PathName("/Script/Engine.TypedElementWorldInterface")]
	public partial class UTypedElementWorldInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TypedElementWorldInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.TypedElementWorldInterface")]
	public interface ITypedElementWorldInterface : IInterface
	{
		 bool SetWorldTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform);

		 bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform);

		 bool SetPivotOffset(FScriptTypedElementHandle InElementHandle, FVector InPivotOffset);

		 FScriptTypedElementHandle PromoteElement(FScriptTypedElementHandle InElementHandle, UWorld OverrideWorld = null);

		 void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle);

		 void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle);

		 void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle);

		 bool IsTemplateElement(FScriptTypedElementHandle InElementHandle);

		 bool GetWorldTransform(FScriptTypedElementHandle InElementHandle, ref FTransform OutTransform);

		 bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle, ref FTransform OutTransform);

		 bool GetPivotOffset(FScriptTypedElementHandle InElementHandle, ref FVector OutPivotOffset);

		 UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle);

		 ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle);

		 bool GetBounds(FScriptTypedElementHandle InElementHandle, ref FBoxSphereBounds OutBounds);

		 FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, FVector InLocationOffset);

		 bool DeleteElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, UTypedElementSelectionSet InSelectionSet, FTypedElementDeletionOptions InDeletionOptions);

		 bool CanPromoteElement(FScriptTypedElementHandle InElementHandle);

		 bool CanMoveElement(FScriptTypedElementHandle InElementHandle, ETypedElementWorldType InWorldType);

		 bool CanEditElement(FScriptTypedElementHandle InElementHandle);

		 bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle);

		 bool CanDeleteElement(FScriptTypedElementHandle InElementHandle);
	}
}