namespace Tilia.SDK.PicoIntegration.Tracking.CameraRig
{
    using Unity.XR.PXR;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Utility;

    public class PXRDeviceDetailsRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The Node Type for the record.")]
        [SerializeField]
        private XRNode nodeType;
        /// <summary>
        /// The Node Type for the record.
        /// </summary>
        public XRNode NodeType
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get { return NodeType; } protected set { NodeType = value; } }
        /// <inheritdoc/>
        public override bool IsConnected { get => CheckIsConnected(); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => GetPriority(); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool HasPassThroughCamera { get => true; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets the <see cref="NodeType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="XRNode"/>.</param>
        public virtual void SetNodeType(int index)
        {
            NodeType = EnumExtensions.GetByIndex<XRNode>(index);
        }

        /// <inheritdoc/>
        protected override void EnablePassThrough()
        {
            PXR_Boundary.EnableSeeThroughManual(true);
            base.EnablePassThrough();
        }

        /// <inheritdoc/>
        protected override void DisablePassThrough()
        {
            PXR_Boundary.EnableSeeThroughManual(false);
            base.DisablePassThrough();
        }

        /// <summary>
        /// Converts a given <see cref="XRNode"/> to the appropriate <see cref="PXR_Input.Controller"/> enum.
        /// </summary>
        /// <param name="node">The XR Node to convert.</param>
        /// <returns>The converted controller enum.</returns>
        protected virtual PXR_Input.Controller? ConvertXRNodeToPXRController(XRNode node)
        {
            switch (node)
            {
                case XRNode.LeftHand:
                    return PXR_Input.Controller.LeftController;
                case XRNode.RightHand:
                    return PXR_Input.Controller.RightController;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Checks if the device is connected.
        /// </summary>
        /// <returns>Whether the device is connected.</returns>
        protected virtual bool CheckIsConnected()
        {
            PXR_Input.Controller? device = ConvertXRNodeToPXRController(XRNodeType);
            if (device != null)
            {
                return PXR_Input.IsControllerConnected((PXR_Input.Controller)device);
            }

            return XRDeviceProperties.IsTracked(XRNodeType);
        }

        /// <summary>
        /// Gets the priority of the device.
        /// </summary>
        /// <returns>The priority of this device.</returns>
        protected virtual int GetPriority()
        {
            switch (PXR_Input.GetDominantHand())
            {
                case PXR_Input.Controller.LeftController:
                    return NodeType == XRNode.LeftHand ? 0 : 1;
                case PXR_Input.Controller.RightController:
                    return NodeType == XRNode.RightHand ? 0 : 1;
                default:
                    return 1;
            }
        }
    }
}