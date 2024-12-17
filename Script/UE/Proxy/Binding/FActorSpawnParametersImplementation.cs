using System.Runtime.CompilerServices;
using Script.CoreUObject;
using Script.Engine;

namespace Script.Library
{
	public static partial class FActorSpawnParametersImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FName FActorSpawnParameters_GetNameImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetNameImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AActor FActorSpawnParameters_GetTemplateImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetTemplateImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AActor FActorSpawnParameters_GetOwnerImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetOwnerImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern APawn FActorSpawnParameters_GetInstigatorImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetInstigatorImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ULevel FActorSpawnParameters_GetOverrideLevelImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetOverrideLevelImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UChildActorComponent FActorSpawnParameters_GetOverrideParentComponentImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetOverrideParentComponentImplementation(nint InObject, nint InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ESpawnActorCollisionHandlingMethod FActorSpawnParameters_GetSpawnCollisionHandlingOverrideImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetSpawnCollisionHandlingOverrideImplementation(nint InObject, ESpawnActorCollisionHandlingMethod InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ESpawnActorNameMode FActorSpawnParameters_GetNameModeImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetNameModeImplementation(nint InObject, ESpawnActorNameMode InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EObjectFlags FActorSpawnParameters_GetObjectFlagsImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_SetObjectFlagsImplementation(nint InObject, EObjectFlags InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_FActorSpawnParametersImplementation(FActorSpawnParameters InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FActorSpawnParameters_DestructorImplementation(nint InObject);
	}
}