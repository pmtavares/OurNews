import React, {useEffect, useState, Fragment} from 'react'
import { Grid, Icon, Image, Item } from 'semantic-ui-react'
import agent from '../../app/api/agent'
import { IArticle } from '../../app/models/article';
import moment from 'moment'

const SecondaryArticles = () => {
    const [articles, setArticles] = useState<IArticle[]>([]);

    useEffect(() => {
  
        agent.Articles.listSecondaryLatest().then(response => {
          setArticles(response)
        });
    
        return () => {
          
        }
      }, [])
    return (        
        <Grid>
            
            { articles.length > 0 &&
                    articles.map((data) => (
                    <Fragment key={data.id}>
                        <Grid.Row >                        
                            <Grid.Column width={7}>                 
                                <Image style={{ height: "100%", width: "100%" }} wrapped
                                    src={data.mainPhoto}                         
                                    />                   
                            </Grid.Column>
                            <Grid.Column width={9}>
                                <Item.Group>
                                    <Item>                        
                                        <Item.Content>
                                            <Item.Header as='a'>{data.title}</Item.Header>
                                            <Item.Meta>{data.description}</Item.Meta>
                                            <Item.Description>
                                                {data.content}
                                            </Item.Description>                                              
                                            
                                            <Item.Extra><Icon name='user' />{data.author} 
                                            <Icon name='clock' style={{marginLeft: "10%"}}/>
                                            {moment(data.datePublished).format("DD/MM/YYYY")}
                                            </Item.Extra>
            
                                        </Item.Content>
                                    </Item>
                                </Item.Group>        
                            </Grid.Column>
                            
                            </Grid.Row>
                           
                        </Fragment>
                    ))           
            }
             
        </Grid>
    )
}

export default SecondaryArticles
