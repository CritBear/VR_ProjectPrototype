using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetGrab : XRGrabInteractable
{
    private Vector3 interactorPosition = Vector3.zero;
    private Quaternion interactorRotation = Quaternion.identity;

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        MatchAttachmentPoints(args.interactor);
        
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {

    }
    private void MatchAttachmentPoints(XRBaseInteractor interactor)
    {
        bool isDirect = interactor is XRDirectInteractor;
        attachTransform.position = isDirect ? interactor.attachTransform.position : transform.position;
        attachTransform.rotation = isDirect ? interactor.attachTransform.rotation : transform.rotation;

    }

    protected override void OnSelectExiting(XRBaseInteractor interactor)
    {

    }
    private void ResetAttachmentPoints(XRBaseInteractor interactor)
    {

    }

    private void ClearInteractor(XRBaseInteractor interactor)
    {

    }
    
}
