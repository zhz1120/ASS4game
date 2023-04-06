using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public Portal portalA1;
    public Portal portalA2;
    public Portal portalB1;
    public Portal portalB2;
    public Portal portalC1;
    public Portal portalC2;
    public Portal portalD1;
    public Portal portalD2;

    void Start()
    {
        PairPortals(portalA1, portalA2);
        PairPortals(portalB1, portalB2);
        PairPortals(portalC1, portalC2);
        PairPortals(portalD1, portalD2);
    }

    private void PairPortals(Portal portal1, Portal portal2)
    {
        portal1.pairedPortal = portal2;
        portal2.pairedPortal = portal1;
    }
}
