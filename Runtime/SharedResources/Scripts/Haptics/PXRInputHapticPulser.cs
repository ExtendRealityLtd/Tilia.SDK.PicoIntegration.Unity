namespace Tilia.SDK.PicoIntegration.Haptics
{
    using Unity.XR.PXR;
    using UnityEngine;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="PXR_Input.VibrateType"/> supported haptic device.
    /// </summary>
    public class PXRInputHapticPulser : HapticPulser
    {
        [Tooltip("The controller to pulse.")]
        [SerializeField]
        private PXR_Input.VibrateType controller = PXR_Input.VibrateType.None;
        /// <summary>
        /// The controller to pulse.
        /// </summary>
        public PXR_Input.VibrateType Controller
        {
            get
            {
                return controller;
            }
            set
            {
                controller = value;
            }
        }
        [Tooltip("The duration to pulse Controller for in milliseconds.")]
        [SerializeField]
        private int duration = 100;
        /// <summary>
        /// The duration to pulse <see cref="Controller"/> for in milliseconds.
        /// </summary>
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = Mathf.Clamp(value, 0, 65535);
            }
        }
        [Tooltip("The frequency between each pulse.")]
        [SerializeField]
        [Range(50, 500)]
        private int frequency = 150;
        /// <summary>
        /// The frequency between each pulse.
        /// </summary>
        public int Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }

        /// <inheritdoc />
        protected override void DoBegin()
        {
            PXR_Input.SendHapticImpulse(Controller, Intensity, Duration, Frequency);
        }

        /// <inheritdoc />
        protected override void DoCancel()
        {
            PXR_Input.SendHapticImpulse(Controller, 0, 0);
        }
    }
}