using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationCurveIdentifierExtensions")]
	public partial class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationCurveIdentifierExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InOutIdentifier">
		/// The identifier to set up
		/// </param>
		/// <param name="Name">
		/// Name of the curve to find or add
		/// </param>
		/// <param name="CurveType">
		/// Type of the curve to find or add
		/// </param>
		public static void SetCurveIdentifier(ref FAnimationCurveIdentifier InOutIdentifier, FName Name, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InOutIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CurveType;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetCurveIdentifier, __InBuffer, __OutBuffer);

				InOutIdentifier = *(FAnimationCurveIdentifier*)(__OutBuffer);

			}
		}

		/// <returns>
		/// Whether or not the Curve Identifier is valid
		/// </returns>
		public static bool IsValid(ref FAnimationCurveIdentifier Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __OutBuffer, __ReturnBuffer);

				Identifier = *(FAnimationCurveIdentifier*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The animation curve type for the curve represented by the Curve Identifier
		/// </returns>
		public static ERawCurveTrackTypes GetType(ref FAnimationCurveIdentifier Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetType, __InBuffer, __OutBuffer, __ReturnBuffer);

				Identifier = *(FAnimationCurveIdentifier*)(__OutBuffer);

				return *(ERawCurveTrackTypes*)__ReturnBuffer;
			}
		}

		/// <param name="InOutIdentifier">
		/// [out] Identifier to be converted
		/// </param>
		/// <param name="Channel">
		/// Channel to target
		/// </param>
		/// <param name="Axis">
		/// Axis within channel to target
		/// </param>
		/// <returns>
		/// Valid FAnimationCurveIdentifier if the operation was successful
		/// </returns>
		public static bool GetTransformChildCurveIdentifier(ref FAnimationCurveIdentifier InOutIdentifier, ETransformCurveChannel Channel, EVectorCurveChannel Axis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InOutIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Channel;

				*(byte*)(__InBuffer + 9) = (byte)Axis;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetTransformChildCurveIdentifier, __InBuffer, __OutBuffer, __ReturnBuffer);

				InOutIdentifier = *(FAnimationCurveIdentifier*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The name used for displaying the Curve Identifier
		/// </returns>
		public static FName GetName(ref FAnimationCurveIdentifier Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __GetName, __InBuffer, __OutBuffer, __ReturnBuffer);

				Identifier = *(FAnimationCurveIdentifier*)(__OutBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="InSkeleton">
		/// Skeleton from which to retrieve the curve identifiers
		/// </param>
		/// <param name="CurveType">
		/// Type of the curve identifers to retrieve
		/// </param>
		/// <returns>
		/// Array of FAnimationCurveIdentifier instances each representing a unique curve if the operation was successful, empyty array otherwise
		/// </returns>
		public static TArray<FAnimationCurveIdentifier> GetCurveIdentifiers(USkeleton InSkeleton, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CurveType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurveIdentifiers, __InBuffer, __ReturnBuffer);

				return *(TArray<FAnimationCurveIdentifier>*)__ReturnBuffer;
			}
		}

		public static FAnimationCurveIdentifier GetCurveIdentifier(USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CurveType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurveIdentifier, __InBuffer, __ReturnBuffer);

				return *(FAnimationCurveIdentifier*)__ReturnBuffer;
			}
		}

		/// <param name="InSkeleton">
		/// Skeleton on which to look for the curve name
		/// </param>
		/// <param name="Name">
		/// Name of the curve to find
		/// </param>
		/// <param name="CurveType">
		/// Type of the curve to find
		/// </param>
		/// <returns>
		/// Valid FAnimationCurveIdentifier if the name exists on the skeleton and the operation was successful, invalid otherwise
		/// </returns>
		public static FAnimationCurveIdentifier FindCurveIdentifier(USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CurveType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindCurveIdentifier, __InBuffer, __ReturnBuffer);

				return *(FAnimationCurveIdentifier*)__ReturnBuffer;
			}
		}

		private static uint __SetCurveIdentifier = 0;

		private static uint __IsValid = 0;

		private static uint __GetType = 0;

		private static uint __GetTransformChildCurveIdentifier = 0;

		private static uint __GetName = 0;

		private static uint __GetCurveIdentifiers = 0;

		private static uint __GetCurveIdentifier = 0;

		private static uint __FindCurveIdentifier = 0;
	}
}