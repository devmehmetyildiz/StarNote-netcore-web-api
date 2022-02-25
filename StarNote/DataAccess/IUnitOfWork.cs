using StarNote.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess
{
    interface IUnitOfWork : IDisposable
    {
        IADMenusRepository ADMenusRepository { get; }

        IADOrderproductRepository ADOrderproductRepository { get; }

        IADProductbaseRepository ADProductbaseRepository { get; }

        IADProductoptionRepository ADProductoptionRepository { get; }

        IGLCaseRespository GLCaseRespository { get; }

        IGLCostumertypeRepository GLCostumertypeRepository { get; }

        IGLLisanceRepository GLLisanceRepository { get; }

        IGLNoteRepository GLNoteRepository { get; }

        IGLPaymenttypeRepository GLPaymenttypeRepository { get; }

        IGLProcesstypeRepository GLProcesstypeRepository { get; }

        IGLProducttypeRepository GLProducttypeRepository { get; }

        IGLRemindingpropertyRepository GLRemindingpropertyRepository { get; }

        IGLRemindingRepository GLRemindingRepository { get; }

        IGLSalesmanRepository GLSalesmanRepository { get; }

        IGLSalestypeRepository GLSalestypeRepository { get; }

        IGLStockRepository GLStockRepository { get; }

        IGLTaxRepository GLTaxRepository { get; }

        IGLUnitRepository GLUnitRepository { get; }

        IGLUsersRepository GLUsersRepository { get; }

        IGLRolesRepository GLRolesRepository { get; }

        ISPCostumerorderRepository SPCostumerorderRepository { get; }

        ISPDefinedcostumerRepository SPDefinedcostumerRepository { get; }

        ISPDefinescompanyRepository SPDefinescompanyRepository { get; }

        ISPFilemanagementRepository SPFilemanagementRepository { get; }

        ISPJoborderRepository SPJoborderRepository { get; }

        int Complate();
    }
}
