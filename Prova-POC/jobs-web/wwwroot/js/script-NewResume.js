const handleInprogressCheckbox = (idCheckbox, idInput) => {
    const isChecked = document.querySelector(`#${idCheckbox}`)?.checked
    if (isChecked) {
        document.querySelector(`#${idInput}`).setAttribute('disabled', true)
        return
    }

    document.querySelector(`#${idInput}`).removeAttribute('disabled')
}

const addAcademic = () => {
    const academicItemsList = document.querySelector('#academic-list')
    const id = academicItemsList.childElementCount + 1 || 1
    const itemTemplate = `
                        <div class="academic-item m-b-40" id=${id}>
                            <div class="form-group">
                                <input asp-for="Course" type="text" nome="course" id="course_${id}" placeholder="Curso">
                                <select asp-for="CourseType" name="courseType" id="courseType_${id}" asp-items="Html.GetEnumSelectList<CourseType>()">
                                    <option selected disable value="">Tipo de curso</option>
                                </select>
                            </div>
                            <div class="form-group">
                                <input asp-for="Institution" type="text" nome="institution" id="institution_${id}" placeholder="Instituição">
                            </div>
                            <div class="form-group">
                                <input asp-for="StartDate" type="text" name="startDate" id="startDate_${id}" onfocus="(this.type='date')" onblur="(this.type='text')" placeholder="Data de início" />
                                <input asp-for="EndDate"
                                       type="text"
                                       name="endDate"
                                       id="endDate_${id}"
                                       onfocus="(this.type='date')"
                                       onblur="(this.type='text')"
                                       placeholder="Data de conclusão" />
                                <div class="checkbox-wrapper">
                                    <input type="checkbox"
                                           name="inProgress"
                                           id="inProgress_${id}"
                                           class="checkbox"
                                           onChange="${() => handleInprogressCheckbox(`inProgress_${id}`, `endDate_${id}`)}"
                                    <label for="inProgress_${id}" class="inProgress">Ainda estou cursando</label>
                                </div>
                            </div>
                        </div>
                    <div class="removeEvent">
                        <label for="removeAcademic" class="removeAcademic">Remover formação</label>
                        <button type="button" onclick="removeAcademic()" class="remove">-</button>
                    </div>
`
    academicItemsList.innerHTML += itemTemplate
}


const addJob = () => {
    const jobItemsList = document.querySelector('#job-list')
    const id = jobItemsList.childElementCount + 1 || 1
    const itemTemplate = `
    <div class="job-item m-b-40" id=${id}>
                            <div class="form-group">
                                <input asp-for="Occupation" type="text" nome="occupation" id="occupation_${id}" placeholder="Função">
                                <select asp-for="JobType" name="jobType" id="jobType_${id}" asp-items="Html.GetEnumSelectList<JobType>()">
                                    <option selected disable value="">Tipo de emprego</option>
                                </select>
                            </div>
                            <div class="form-group">
                                <input asp-for="CompanyName" type="text" nome="company" id="company_${id}" placeholder="Empresa">
                            </div>
                            <div class="form-group">
                                <input asp-for="Locality" type="text" nome="local" id="local_${id}" placeholder="Local">
                            </div>
                            <div class="form-group">
                                <input asp-for="StartDate" type="text" name="startDate" id="startDate_${id}" onfocus="(this.type='date')" onblur="(this.type='text')" placeholder="Data de início" />
                                <input asp-for="EndDate" type="text" name="endDateJob" id="endDateJob_${id}" onfocus="(this.type='date')" onblur="(this.type='text')" placeholder="Data de saída" />
                                <div class="checkbox-wrapper">
                                    <input type="checkbox"
                                           name="actualJob"
                                           id="actualJob_${id}"
                                           class="checkbox"
                                           onChange="${() => handleInprogressCheckbox(`actualJob_${id}`, `endDateJob_${id}`)}"
                                    <label for="inProgress" class="inProgress">Meu emprego atual</label>
                                </div>
                            </div>
                            <textarea asp-for="Description" class="form-group description" name="description" id="description_${id}" cols="30" rows="10" placeholder="Descrição"></textarea>
                        </div>
                    <div class="removeEvent">
                        <label for="removeJob" class="removeJob">Remover experiência</label>
                        <button type="button" onclick="removeJob()" class="remove">-</button>
                    </div>
`

    jobItemsList.innerHTML += itemTemplate
}







