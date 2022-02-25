using StarNote.DataAccess.Repositories.Abstract;
using StarNote.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private Starnoteapicontext _starnoteapicontext;
        public UnitOfWork(Starnoteapicontext context)
        {
            _starnoteapicontext = context;
            ADMenusRepository = new ADMenusRepository(_starnoteapicontext);
            ADOrderproductRepository = new ADOrderproductRepository(_starnoteapicontext);
            ADProductbaseRepository = new ADProductbaseRepository(_starnoteapicontext);
            ADOrderproductRepository = new ADOrderproductRepository(_starnoteapicontext);
            ADProductoptionRepository = new ADProductoptionRepository(_starnoteapicontext);
            GLCaseRespository = new GLCaseRespository(_starnoteapicontext);
            GLCostumertypeRepository = new GLCostumertypeRepository(_starnoteapicontext);
            GLLisanceRepository = new GLLisanceRepository(_starnoteapicontext);
            GLNoteRepository = new GLNoteRepository(_starnoteapicontext);
            GLPaymenttypeRepository = new GLPaymenttypeRepository(_starnoteapicontext);
            GLProcesstypeRepository = new GLProcesstypeRepository(_starnoteapicontext);
            GLProducttypeRepository = new GLProducttypeRepository(_starnoteapicontext);
            GLRemindingpropertyRepository = new GLRemindingpropertyRepository(_starnoteapicontext);
            GLRemindingRepository = new GLRemindingRepository(_starnoteapicontext);
            GLSalesmanRepository = new GLSalesmanRepository(_starnoteapicontext);
            GLSalestypeRepository = new GLSalestypeRepository(_starnoteapicontext);
            GLStockRepository = new GLStockRepository(_starnoteapicontext);
            GLTaxRepository = new GLTaxRepository(_starnoteapicontext);
            GLUnitRepository = new GLUnitRepository(_starnoteapicontext);
            GLUsersRepository = new GLUsersRepository(_starnoteapicontext);
            GLRolesRepository = new GLRolesRepository(_starnoteapicontext);
            SPCostumerorderRepository = new SPCostumerorderRepository(_starnoteapicontext);
            SPDefinedcostumerRepository = new SPDefinedcostumerRepository(_starnoteapicontext);
            SPDefinescompanyRepository = new SPDefinescompanyRepository(_starnoteapicontext);
            SPFilemanagementRepository = new SPFilemanagementRepository(_starnoteapicontext);
            SPJoborderRepository = new SPJoborderRepository(_starnoteapicontext);

        }

        public IADMenusRepository ADMenusRepository { get; private set; }

        public IADOrderproductRepository ADOrderproductRepository { get; private set; }

        public IADProductbaseRepository ADProductbaseRepository { get; private set; }

        public IADProductoptionRepository ADProductoptionRepository { get; private set; }

        public IGLCaseRespository GLCaseRespository { get; private set; }

        public IGLCostumertypeRepository GLCostumertypeRepository { get; private set; }

        public IGLLisanceRepository GLLisanceRepository { get; private set; }

        public IGLNoteRepository GLNoteRepository { get; private set; }

        public IGLPaymenttypeRepository GLPaymenttypeRepository { get; private set; }

        public IGLProcesstypeRepository GLProcesstypeRepository { get; private set; }

        public IGLProducttypeRepository GLProducttypeRepository { get; private set; }

        public IGLRemindingpropertyRepository GLRemindingpropertyRepository { get; private set; }

        public IGLRemindingRepository GLRemindingRepository { get; private set; }

        public IGLSalesmanRepository GLSalesmanRepository { get; private set; }

        public IGLSalestypeRepository GLSalestypeRepository { get; private set; }

        public IGLStockRepository GLStockRepository { get; private set; }

        public IGLTaxRepository GLTaxRepository { get; private set; }

        public IGLUnitRepository GLUnitRepository { get; private set; }

        public IGLUsersRepository GLUsersRepository { get; private set; }

        public ISPCostumerorderRepository SPCostumerorderRepository { get; private set; }

        public ISPDefinedcostumerRepository SPDefinedcostumerRepository { get; private set; }

        public ISPDefinescompanyRepository SPDefinescompanyRepository { get; private set; }

        public ISPFilemanagementRepository SPFilemanagementRepository { get; private set; }

        public ISPJoborderRepository SPJoborderRepository { get; private set; }

        public IGLRolesRepository GLRolesRepository { get; private set; }

        public int Complate()
        {
            return _starnoteapicontext.SaveChanges();
        }

        public void Dispose()
        {
            _starnoteapicontext.Dispose();
        }
    }
}
