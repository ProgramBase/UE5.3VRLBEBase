using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.AnimationCore;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.ConstraintsScriptingLibrary")]
	public partial class UConstraintsScriptingLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.ConstraintsScriptingLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InWorld">
		/// World to remove the constraint
		/// </param>
		/// <param name="InTickableConstraint">
		/// Constraint to remove
		/// </param>
		/// <returns>
		/// return If constraint removed correctly
		/// </returns>
		public static bool RemoveThisConstraint(UWorld InWorld, UTickableConstraint InTickableConstraint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTickableConstraint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveThisConstraint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World to remove the constraint
		/// </param>
		/// <param name="InIndex">
		/// Index to remove from
		/// </param>
		/// <returns>
		/// return If constraint removed correctly
		/// </returns>
		public static bool RemoveConstraint(UWorld InWorld, int InIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveConstraint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// , the world you are in
		/// </param>
		/// <returns>
		/// Returns the mananger
		/// </returns>
		public static UConstraintsManager GetManager(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetManager, __InBuffer, __ReturnBuffer);

				return *(UConstraintsManager*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World we are in
		/// </param>
		/// <returns>
		/// Copy of the constraints in the level
		/// </returns>
		public static TArray<UTickableConstraint> GetConstraintsArray(UWorld InWorld)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConstraintsArray, __InBuffer, __ReturnBuffer);

				return *(TArray<UTickableConstraint>*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// , the world you are in
		/// </param>
		/// <param name="InObject">
		/// World to create the constraint
		/// </param>
		/// <param name="InAttachmentName">
		/// Optional name of the attachment to get the transform. Not that this can represent a scene component's socket name or a control rig control for example. 
		/// </param>
		/// <returns>
		/// returns the handle for this scene component
		/// </returns>
		public static UTransformableHandle CreateTransformableHandle(UWorld InWorld, UObject InObject, FName InAttachmentName = null)
		{
			unsafe
			{
				InAttachmentName ??= new FName("None");

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InAttachmentName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateTransformableHandle, __InBuffer, __ReturnBuffer);

				return *(UTransformableHandle*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// , the world you are in
		/// </param>
		/// <param name="InSceneComponent">
		/// World to create the constraint
		/// </param>
		/// <param name="InSocketName">
		/// Optional name of the socket to get the transform 
		/// </param>
		/// <returns>
		/// returns the handle for this scene component
		/// </returns>
		public static UTransformableComponentHandle CreateTransformableComponentHandle(UWorld InWorld, USceneComponent InSceneComponent, FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSceneComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateTransformableComponentHandle, __InBuffer, __ReturnBuffer);

				return *(UTransformableComponentHandle*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World to create the constraint
		/// </param>
		/// <param name="InType">
		/// The type of constraint
		/// </param>
		/// <returns>
		/// return The constraint object
		/// </returns>
		public static UTickableTransformConstraint CreateFromType(UWorld InWorld, ETransformConstraintType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateFromType, __InBuffer, __ReturnBuffer);

				return *(UTickableTransformConstraint*)__ReturnBuffer;
			}
		}

		/// <param name="InWorld">
		/// World to create the constraint
		/// </param>
		/// <param name="InParentHandle">
		/// The parent handle
		/// </param>
		/// <param name="InChildHandle">
		/// The child handle
		/// </param>
		/// <param name="InConsrtaint">
		/// The constraint
		/// </param>
		/// <returns>
		/// return If constraint added correctly
		/// </returns>
		public static bool AddConstraint(UWorld InWorld, UTransformableHandle InParentHandle, UTransformableHandle InChildHandle, UTickableTransformConstraint InConstraint, bool bMaintainOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = InWorld?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParentHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InChildHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InConstraint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bMaintainOffset;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddConstraint, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __RemoveThisConstraint = 0;

		private static uint __RemoveConstraint = 0;

		private static uint __GetManager = 0;

		private static uint __GetConstraintsArray = 0;

		private static uint __CreateTransformableHandle = 0;

		private static uint __CreateTransformableComponentHandle = 0;

		private static uint __CreateFromType = 0;

		private static uint __AddConstraint = 0;
	}
}